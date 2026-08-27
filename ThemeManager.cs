using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SandsTrilogyKiller
{
    public static class ThemeManager
    {
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public static bool IsSystemDarkMode()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        var value = key.GetValue("AppsUseLightTheme");
                        if (value is int intValue)
                        {
                            return intValue == 0;
                        }
                    }
                }
            }
            catch
            {
                // Fallback to light mode on error
            }
            return false;
        }

        public static void SetTitleBarDarkMode(IntPtr handle, bool enable)
        {
            if (handle == IntPtr.Zero) return;
            try
            {
                int useDarkMode = enable ? 1 : 0;
                if (DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int)) != 0)
                {
                    DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1, ref useDarkMode, sizeof(int));
                }
            }
            catch
            {
                // Ignore if not supported on older Windows
            }
        }

        public static void ApplyTheme(Form form, bool isDark)
        {
            if (form == null || form.IsDisposed) return;

            SetTitleBarDarkMode(form.Handle, isDark);

            Color backColor = isDark ? Color.FromArgb(32, 32, 32) : SystemColors.Control;
            Color foreColor = isDark ? Color.FromArgb(240, 240, 240) : SystemColors.ControlText;
            Color inputBack = isDark ? Color.FromArgb(45, 45, 45) : SystemColors.Window;
            Color inputFore = isDark ? Color.FromArgb(240, 240, 240) : SystemColors.WindowText;
            Color buttonBack = isDark ? Color.FromArgb(55, 55, 55) : SystemColors.Control;
            Color buttonBorder = isDark ? Color.FromArgb(75, 75, 75) : SystemColors.ControlDark;

            form.BackColor = backColor;
            form.ForeColor = foreColor;

            ApplyThemeToControls(form.Controls, isDark, backColor, foreColor, inputBack, inputFore, buttonBack, buttonBorder);

            if (form.ContextMenuStrip != null)
            {
                ApplyContextMenuTheme(form.ContextMenuStrip, isDark);
            }
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls, bool isDark,
            Color backColor, Color foreColor, Color inputBack, Color inputFore, Color buttonBack, Color buttonBorder)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.BackColor = inputBack;
                    textBox.ForeColor = inputFore;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is NumericUpDown num)
                {
                    num.BackColor = inputBack;
                    num.ForeColor = inputFore;
                    num.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox combo)
                {
                    combo.BackColor = inputBack;
                    combo.ForeColor = inputFore;
                    combo.FlatStyle = isDark ? FlatStyle.Flat : FlatStyle.Standard;
                }
                else if (control is Button btn)
                {
                    btn.BackColor = buttonBack;
                    btn.ForeColor = foreColor;
                    btn.FlatStyle = isDark ? FlatStyle.Flat : FlatStyle.Standard;
                    btn.FlatAppearance.BorderColor = buttonBorder;
                }
                else if (control is CheckBox chk)
                {
                    chk.ForeColor = foreColor;
                    chk.BackColor = backColor;
                    if (chk.ContextMenuStrip != null)
                    {
                        ApplyContextMenuTheme(chk.ContextMenuStrip, isDark);
                    }
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = foreColor;
                    lbl.BackColor = backColor;
                }
                else
                {
                    control.BackColor = backColor;
                    control.ForeColor = foreColor;
                }

                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls, isDark, backColor, foreColor, inputBack, inputFore, buttonBack, buttonBorder);
                }
            }
        }

        public static void ApplyContextMenuTheme(ContextMenuStrip menu, bool isDark)
        {
            if (menu == null) return;
            if (isDark)
            {
                menu.Renderer = new DarkToolStripRenderer();
                menu.BackColor = Color.FromArgb(40, 40, 40);
                menu.ForeColor = Color.FromArgb(240, 240, 240);
                ApplyToolStripItemsTheme(menu.Items, true);
            }
            else
            {
                menu.Renderer = new ToolStripProfessionalRenderer();
                menu.BackColor = SystemColors.Control;
                menu.ForeColor = SystemColors.ControlText;
                ApplyToolStripItemsTheme(menu.Items, false);
            }
        }

        private static void ApplyToolStripItemsTheme(ToolStripItemCollection items, bool isDark)
        {
            Color foreColor = isDark ? Color.FromArgb(240, 240, 240) : SystemColors.ControlText;
            Color backColor = isDark ? Color.FromArgb(40, 40, 40) : SystemColors.Control;
            Color inputBack = isDark ? Color.FromArgb(50, 50, 50) : SystemColors.Window;
            Color inputFore = isDark ? Color.FromArgb(240, 240, 240) : SystemColors.WindowText;

            foreach (ToolStripItem item in items)
            {
                item.ForeColor = foreColor;
                item.BackColor = backColor;

                if (item is ToolStripComboBox combo)
                {
                    combo.ComboBox.BackColor = inputBack;
                    combo.ComboBox.ForeColor = inputFore;
                    combo.ComboBox.FlatStyle = isDark ? FlatStyle.Flat : FlatStyle.Standard;
                }
                else if (item is ToolStripMenuItem menuItem && menuItem.HasDropDownItems)
                {
                    menuItem.DropDown.BackColor = backColor;
                    menuItem.DropDown.ForeColor = foreColor;
                    if (isDark)
                    {
                        menuItem.DropDown.Renderer = new DarkToolStripRenderer();
                    }
                    else
                    {
                        menuItem.DropDown.Renderer = new ToolStripProfessionalRenderer();
                    }
                    ApplyToolStripItemsTheme(menuItem.DropDownItems, isDark);
                }
            }
        }

        private class DarkToolStripRenderer : ToolStripProfessionalRenderer
        {
            public DarkToolStripRenderer() : base(new DarkColorTable()) { }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = Color.FromArgb(240, 240, 240);
                base.OnRenderItemText(e);
            }

            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
            {
                e.ArrowColor = Color.FromArgb(240, 240, 240);
                base.OnRenderArrow(e);
            }
        }

        private class DarkColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected => Color.FromArgb(60, 60, 60);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(60, 60, 60);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(60, 60, 60);
            public override Color MenuItemBorder => Color.FromArgb(80, 80, 80);
            public override Color MenuBorder => Color.FromArgb(60, 60, 60);
            public override Color ToolStripDropDownBackground => Color.FromArgb(40, 40, 40);
            public override Color ImageMarginGradientBegin => Color.FromArgb(40, 40, 40);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(40, 40, 40);
            public override Color ImageMarginGradientEnd => Color.FromArgb(40, 40, 40);
            public override Color SeparatorDark => Color.FromArgb(70, 70, 70);
            public override Color SeparatorLight => Color.FromArgb(50, 50, 50);
        }
    }
}

