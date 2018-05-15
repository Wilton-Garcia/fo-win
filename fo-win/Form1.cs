using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fo_win
{
    public partial class Form1 : Form
    {

        private string dirFinalPdf;
        private string dirFinalImages;
        private string dirFinalVideos;
        private string dirFinalExec;
        private string dirFinalOffice;
        private string dirFinalAudios;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirDiretorioAlvo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtCaminhoPastaAlvo.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnAbrirDiretorioFinalPDF_Click(object sender, EventArgs e)
        {

            folderBrowserDialog.ShowDialog();
            txbDiretorioFinalPDF.Text = folderBrowserDialog.SelectedPath;
            dirFinalPdf = folderBrowserDialog.SelectedPath;
        }

        private void btnAbrirDiretorioFinalExe_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txbDiretorioFinalExe.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnOrganizarPasta_Click(object sender, EventArgs e)
        {
            string pastaAlvo = txtCaminhoPastaAlvo.Text.ToString();
            DirectoryInfo dirAlvo = new DirectoryInfo(pastaAlvo);

            foreach(FileInfo f in dirAlvo.GetFiles())
            {
                if(f.Extension.Equals(".pdf"))
                {
                
                    f.MoveTo(dirFinalPdf+"\\"+f.Name);
                }
                else if (f.Extension.Equals(".png") 
                    || f.Extension.Equals(".jpeg")
                    || f.Extension.Equals(".gif")
                    || f.Extension.Equals(".bitmap")
                    || f.Extension.Equals(".jpeg")
                    || f.Extension.Equals(".svg"))
                {
                    f.MoveTo(dirFinalImages+"\\"+f.Name);
                   
                }
                else if (f.Extension.Equals(".mp3"))
                {
                    f.MoveTo(dirFinalAudios + "\\"+f.Name);
                    
                }
                else if (f.Extension.Equals(".mp4"))
                {
                    f.MoveTo(dirFinalVideos + "\\" + f.Name);
                }
                
                
            }


        }

        private void btnAbrirDiretorioFinalImagens_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txbDiretorioFinalImagens.Text = folderBrowserDialog.SelectedPath;
            dirFinalImages = folderBrowserDialog.SelectedPath;
        }
    }
}
