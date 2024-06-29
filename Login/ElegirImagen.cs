using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class ElegirImagen : Form
    {
        private byte imagenSeleccionada;
        public byte ImagenSeleccionada { get => imagenSeleccionada; set => imagenSeleccionada = value; }
        private ImageList listaImagenes = new ImageList();
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public ElegirImagen()
        {
            InitializeComponent();
            LlenarListView();
        }

        private void LlenarListView()
        {
            listaImagenes.ColorDepth = ColorDepth.Depth32Bit;
            listaImagenes.ImageSize = new Size(128, 128);
            listaImagenes.Images.Add(Properties.Resources.fotoUsuario_removebg_preview);
            listaImagenes.Images.Add(Properties.Resources.img1);
            listaImagenes.Images.Add(Properties.Resources.img2);
            listaImagenes.Images.Add(Properties.Resources.img3);
            listaImagenes.Images.Add(Properties.Resources.img4);
            listaImagenes.Images.Add(Properties.Resources.img5);
            listaImagenes.Images.Add(Properties.Resources.img6);
            listaImagenes.Images.Add(Properties.Resources.img7);
            listaImagenes.Images.Add(Properties.Resources.img8);
            listaImagenes.Images.Add(Properties.Resources.img9);
            listaImagenes.Images.Add(Properties.Resources.img10);
            listaImagenes.Images.Add(Properties.Resources.img11);
            listaImagenes.Images.Add(Properties.Resources.img12);
            listaImagenes.Images.Add(Properties.Resources.img13);
            listaImagenes.Images.Add(Properties.Resources.img14);
            listaImagenes.Images.Add(Properties.Resources.img15);

            listaViewImagenes.View = View.LargeIcon;
            listaViewImagenes.LargeImageList = listaImagenes;
            listaViewImagenes.Dock = DockStyle.None;

            for (int i = 0; i < listaImagenes.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                listaViewImagenes.Items.Add(item);
            }
        }

        private void boton_ImagenClick(object sender, EventArgs e)
        {
            if (listaViewImagenes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaViewImagenes.SelectedItems[0];
                imagenSeleccionada = Convert.ToByte(selectedItem.ImageIndex);
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una imagen.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ListViewItem selectedItem;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                try
                {
                    selectedItem = listaViewImagenes.SelectedItems[0];
                    imagenSeleccionada = Convert.ToByte(selectedItem.ImageIndex);
                }
                catch
                {
                    imagenSeleccionada = 0;
                }
            }
        }

        public ImageList GetListImage()
        {
            return listaImagenes;
        }

        private void panelVentana_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelVentana_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelVentana_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FondoPanelOn(Panel panel)
        {
            panel.BackColor = Color.FromArgb(42, 40, 120);
        }
        private void FondoPanelOff(Panel panel)
        {
            panel.BackColor = Color.FromArgb(42, 40, 51);
        }

        private void panelCerrar_MouseEnter(object sender, EventArgs e)
        {
            FondoPanelOn(panelCerrar);
        }

        private void panelMinimizar_MouseEnter(object sender, EventArgs e)
        {
            FondoPanelOn(panelMinimizar);
        }

        private void panelMinimizar_MouseLeave(object sender, EventArgs e)
        {
            FondoPanelOff(panelMinimizar);
        }

        private void panelCerrar_MouseLeave(object sender, EventArgs e)
        {
            FondoPanelOff(panelCerrar);
        }
    }
}
