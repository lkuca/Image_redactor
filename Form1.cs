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
        ToolStrip toolstrip;
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
             windowMenuEdit = new ToolStripMenuItem("Edit");
             windowMenuHelp = new ToolStripMenuItem("Help");
             windowMenuNEW = new ToolStripMenuItem("NEW");
             windowMenuNEW.Text = "&New";
            // Assign a shortcut key.
            windowMenuNEW.ShortcutKeys = Keys.Control | Keys.N;
            // Make the menu item visible.
            windowMenuNEW.Visible = true;
            // Display the shortcut key combination.
            windowMenuNEW.ShowShortcutKeys = true;
            windowMenuOpen = new ToolStripMenuItem("Open");
            windowMenuNEW.Text = "&New";
            // Assign a shortcut key.
            windowMenuNEW.ShortcutKeys = Keys.Control | Keys.N;
            // Make the menu item visible.
            windowMenuNEW.Visible = true;
            // Display the shortcut key combination.
            windowMenuNEW.ShowShortcutKeys = true;

            windowMenuSave = new ToolStripMenuItem("Save");
             windowMenuExit = new ToolStripMenuItem("Exit");
             windowMenuUndo = new ToolStripMenuItem("Undo");
             windowMenuReno = new ToolStripMenuItem("Reno");
             windowMenuPen = new ToolStripMenuItem("Pen");
             windowMenuStyle = new ToolStripMenuItem("Style");
             windowMenuSolid = new ToolStripMenuItem("Solid");
             windowMenuDot = new ToolStripMenuItem("Dot");
             windowMenuDASHDOTDOT = new ToolStripMenuItem("DashDOTDOT");








             windowMenuAbout = new ToolStripMenuItem("About");





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