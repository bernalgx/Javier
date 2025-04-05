using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ServidorApp
{
	public partial class FrmServidor : Form
	{
		// Configuración del servidor
		private readonly IPAddress direccion = IPAddress.Parse("127.0.0.1");
		private readonly int puerto = 14100;
		private TcpListener listener;
		private bool isRunning;
		private List<TcpClient> clientes = new List<TcpClient>();
		private SemaphoreSlim conexionSemaphore = new SemaphoreSlim(5); // Limita a 5 conexiones

		public FrmServidor()
		{
			InitializeComponent();
			// Inicia el servidor en un subproceso para que no bloquee la interfaz
			Thread serverThread = new Thread(IniciarServidor)
			{
				IsBackground = true
			};
			serverThread.Start();
		}

		/// <summary>
		/// Inicia el servidor TCP y comienza a aceptar clientes.
		/// </summary>
		private void IniciarServidor()
		{
			try
			{
				listener = new TcpListener(direccion, puerto);
				listener.Start();
				isRunning = true;
				AgregarBitacora("Servidor iniciado en " + direccion.ToString() + ":" + puerto);
				while (isRunning)
				{
					// Espera un "slot" disponible (máximo 5 conexiones)
					conexionSemaphore.Wait();

					// Acepta una nueva conexión (este método es bloqueante)
					TcpClient cliente = listener.AcceptTcpClient();
					lock (clientes)
					{
						clientes.Add(cliente);
					}
					ActualizarClientesConectados();
					AgregarBitacora("Cliente conectado: " + cliente.Client.RemoteEndPoint.ToString());

					// Atiende al cliente en un hilo independiente
					Thread hiloCliente = new Thread(() => ManejarCliente(cliente))
					{
						IsBackground = true
					};
					hiloCliente.Start();
				}
			}
			catch (Exception ex)
			{
				AgregarBitacora("Error en el servidor: " + ex.Message);
			}
		}

		/// <summary>
		/// Maneja la comunicación con un cliente.
		/// </summary>
		/// <param name="cliente">El cliente conectado.</param>
		private void ManejarCliente(TcpClient cliente)
		{
			try
			{
				NetworkStream stream = cliente.GetStream();
				byte[] buffer = new byte[1024];
				int bytesLeidos;
				while ((bytesLeidos = stream.Read(buffer, 0, buffer.Length)) != 0)
				{
					string mensaje = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);
					AgregarBitacora("Mensaje recibido de " + cliente.Client.RemoteEndPoint.ToString() + ": " + mensaje);
					// Aquí puedes invocar tu método para procesar el mensaje (ej. SeleccionarMetodo)
				}
			}
			catch (Exception ex)
			{
				AgregarBitacora("Error con cliente: " + ex.Message);
			}
			finally
			{
				cliente.Close();
				lock (clientes)
				{
					clientes.Remove(cliente);
				}
				ActualizarClientesConectados();
				AgregarBitacora("Cliente desconectado.");
				conexionSemaphore.Release(); // Permite nuevas conexiones
			}
		}

		/// <summary>
		/// Agrega un evento a la bitácora en la interfaz.
		/// </summary>
		/// <param name="mensaje">Mensaje del evento.</param>
		private void AgregarBitacora(string mensaje)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<string>(AgregarBitacora), mensaje);
			}
			else
			{
				string tiempo = DateTime.Now.ToString("HH:mm:ss");
				richTextBoxBitacora.AppendText($"[{tiempo}] {mensaje}{Environment.NewLine}");
			}
		}

		/// <summary>
		/// Actualiza la cantidad de clientes conectados en el label.
		/// </summary>
		private void ActualizarClientesConectados()
		{
			if (InvokeRequired)
			{
				Invoke(new Action(ActualizarClientesConectados));
			}
			else
			{
				labelClientesConectados.Text = "Clientes conectados: " + clientes.Count;
			}
		}

		/// <summary>
		/// Se detiene el servidor al cerrar el formulario.
		/// </summary>
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			isRunning = false;
			listener?.Stop();
			base.OnFormClosing(e);
		}
	}
}
