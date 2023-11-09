using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;















namespace Image_redactor
{
    public partial class Form1 : Form
    {
        MenuStrip menu;
        System.Windows.Forms.ToolStrip toolstrip;
        Panel p;
        ColorDialog colordiag;
        OpenFileDialog openfilDia;
        SaveFileDialog savfildiag;
        PictureBox pb;
        ImageList il;
        TrackBar trackb;
        ComboBox cbx;
        ToolStripMenuItem windowMenuAbout, windowMenuFile, windowMenuEdit, windowMenuHelp, windowMenuNEW, windowMenuOpen, windowMenuSave, windowMenuExit, windowMenuUndo, windowMenuReno, windowMenuPen, windowMenuStyle, windowMenuSolid,
         windowMenuDot, windowMenuDASHDOTDOT;
        public Form1()
        {

            InitializeComponent();
            this.Height = 600;
            this.Width = 800;
            this.Text = "Paiint";
            menu = new MenuStrip();
            
             windowMenuFile = new ToolStripMenuItem("File");
             windowMenuEdit = new ToolStripMenuItem("Muuta");
             windowMenuHelp = new ToolStripMenuItem("Abi");
            
            windowMenuNEW = new ToolStripMenuItem("Uus");
            windowMenuNEW.Text = "&Uus";
            // Assign a shortcut key.
            windowMenuNEW.ShortcutKeys = Keys.Control | Keys.N;
            // Make the menu item visible.
            windowMenuNEW.Visible = true;
            // Display the shortcut key combination.
            windowMenuNEW.ShowShortcutKeys = true;
            windowMenuOpen = new ToolStripMenuItem("Ava");
            windowMenuOpen.Text = "&Ava";
            // Assign a shortcut key.
            windowMenuOpen.ShortcutKeys = Keys.F3;
            // Make the menu item visible.
            windowMenuOpen.Visible = true;
            // Display the shortcut key combination.
            windowMenuOpen.ShowShortcutKeys = true;
            
            

            windowMenuSave = new ToolStripMenuItem("Salvesta");
            windowMenuSave.Text = "&Salvesta";
            // Assign a shortcut key.
            windowMenuSave.ShortcutKeys = Keys.F2;
            // Make the menu item visible.
            windowMenuSave.Visible = true;
            // Display the shortcut key combination.
            windowMenuSave.ShowShortcutKeys = true;
            windowMenuExit = new ToolStripMenuItem("Sule");
            windowMenuExit.Text = "&Sule";
            // Assign a shortcut key.
            windowMenuExit.ShortcutKeys = Keys.Alt | Keys.X;
            // Make the menu item visible.
            windowMenuExit.Visible = true;
            // Display the shortcut key combination.
            windowMenuExit.ShowShortcutKeys = true;
            windowMenuUndo = new ToolStripMenuItem("Undo");
            windowMenuUndo.Text = "&Undo";
            // Assign a shortcut key.
            windowMenuUndo.ShortcutKeys = Keys.Control | Keys.Z;
            // Make the menu item visible.
            windowMenuUndo.Visible = true;
            // Display the shortcut key combination.
            windowMenuUndo.ShowShortcutKeys = true;
            windowMenuReno = new ToolStripMenuItem("Reno");
            windowMenuReno.Text = "&Reno";
            // Assign a shortcut key.
            windowMenuReno.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            // Make the menu item visible.
            windowMenuReno.Visible = true;
            // Display the shortcut key combination.
            windowMenuReno.ShowShortcutKeys = true;
            windowMenuPen = new ToolStripMenuItem("Pliiats");
            windowMenuPen.Checked = true;
             windowMenuStyle = new ToolStripMenuItem("Stiil");
            windowMenuStyle.Checked = true;
             windowMenuSolid = new ToolStripMenuItem("Solid");
            windowMenuSolid.Checked = true;
             windowMenuDot = new ToolStripMenuItem("Dot");
             windowMenuDASHDOTDOT = new ToolStripMenuItem("DashDOTDOT");








             windowMenuAbout = new ToolStripMenuItem("About(Umbes)");
            windowMenuAbout.Text = "&About(Umbes)";
            // Assign a shortcut key.
            windowMenuAbout.ShortcutKeys = Keys.F1;
            // Make the menu item visible.
            windowMenuAbout.Visible = true;
            // Display the shortcut key combination.
            windowMenuAbout.ShowShortcutKeys = true;




            //ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(windowNewMenu_Click));
            //windowMenu.DropDownItems.Add(windowNewMenu);

            menu.Items.Add(windowMenuEdit);
            menu.Items.Add(windowMenuHelp);
            menu.Items.Add(windowMenuFile);
            windowMenuFile.DropDownItems.Add(windowMenuNEW);
            windowMenuFile.DropDownItems.Add(windowMenuOpen);
            windowMenuFile.DropDownItems.Add(windowMenuSave);
            windowMenuFile.DropDownItems.Add(windowMenuExit);
            windowMenuEdit.DropDownItems.Add(windowMenuUndo);
            windowMenuEdit.DropDownItems.Add(windowMenuReno);
            windowMenuEdit.DropDownItems.Add(windowMenuPen);
            windowMenuHelp.DropDownItems.Add(windowMenuAbout);
            windowMenuPen.DropDownItems.Add(windowMenuStyle);
            windowMenuStyle.DropDownItems.Add(windowMenuSolid);
            windowMenuStyle.DropDownItems.Add(windowMenuDot);
            windowMenuStyle.DropDownItems.Add(windowMenuDASHDOTDOT);


            menu.Visible = true;
            this.Controls.Add(menu);
            




        }
        private bool ShowShortcutKeys { get; set; }
        private void SetupMyMenuItem(object sender, EventArgs e)
        {
            //// Set the caption for the menu item.
            //windowMenuNEW.Text = "&New";
            //// Assign a shortcut key.
            //windowMenuNEW.Shortcut = Shortcut.CtrlN;
            //// Make the menu item visible.
            //windowMenuNEW.Visible = true;
            //// Display the shortcut key combination.
            //windowMenuNEW.ShowShortcut = true;
        }


    }
    
}