using Proycto_Mensajeria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proycto_Mensajeria
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;//Definir el identificador
        private Cola<Usuario> colaUsuarios;
        private Productor productor;
        private Consumidor consumidor;

        public Form1()
        {
            InitializeComponent();
            colaUsuarios = new Cola<Usuario>(10);
            productor = new Productor(colaUsuarios);
            consumidor = new Consumidor(colaUsuarios);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(
               contadorId++,
               txtNombre.Text,
               txtMensaje.Text,
               txtReceptor.Text,
               txtRespuesta.Text,
               txtCorreo.Text
               );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuarios.Agregar(nuevoUsuario);

                }
                );
            txtNombre.Clear();
            txtMensaje.Clear();
            txtReceptor.Clear();
            txtRespuesta.Clear();
            txtCorreo.Clear();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            {
                Thread hiloConsumidor = new Thread(ProcesarUsuario);
                hiloConsumidor.Start();
            }
        }
            private void ProcesarUsuario()
            {
                Usuario usuario = colaUsuarios.Extraer();
                AgregarUsuarioADataGrid(usuario);
            }

            private void AgregarUsuarioADataGrid(Usuario usuario)
            {
                if (dgvMensajeria.InvokeRequired)
                {
                    dgvMensajeria.Invoke(new Action(() =>
                    {
                        dgvMensajeria.Rows.Add(
                            usuario.Id, usuario.Nombre, usuario.CorreoElectronico, usuario.Fecha,usuario.NombreReceptor,usuario.Respuesta
                            );
                    })

                    );
                }
                else
                {
                    dgvMensajeria.Rows.Add(
                        usuario.Id, usuario.Nombre, usuario.CorreoElectronico, usuario.Fecha,usuario.NombreReceptor, usuario.Respuesta
                        );
                }
            
        }
        
    }
}
