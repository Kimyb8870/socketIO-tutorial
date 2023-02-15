using SocketIOClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SocketIO client;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                Console.WriteLine("already connected");
                return;
            }

            connectSocket();

        }

        private async void connectSocket()
        {
            //client = new SocketIO("http://192.168.0.7:3000/", new SocketIOOptions
            //{
            //    Reconnection = true,
            //    ReconnectionAttempts = int.MaxValue,
            //    ReconnectionDelay = 1000,
            //    ConnectionTimeout = 20000
            //    ConnectionTimeout = new TimeSpan(0, 0, 3),
            //});

            client = new SocketIO("http://localhost:3000/");

            socketIOManager(client);

            await client.ConnectAsync();
            await client.EmitAsync("join-room", "a211");
        }

        private void socketIOManager(SocketIO client)
        {   
            client.OnConnected += (sender, e) =>
            {
                Console.WriteLine("Succssfully connected");
            };

            client.OnDisconnected += (sender, e) =>
            {
                Console.WriteLine("Disconnected");
            };

            client.On("control-request", response =>
            {
                Console.WriteLine(response);
            });

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(client == null)
            {
                Console.WriteLine("client is not connected with server yet");
                return;
            }

            if(client !=null && !client.Connected)
            {
                Console.WriteLine("disconnected with server");
            }

            Console.WriteLine("Connected?" + client.Connected);

            client.EmitAsync("control-finish", messageBox.Text, "");
        }

        private void deviceIdSetBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                Console.WriteLine("client is not connected with server yet");
                return;
            }

            if (client != null && !client.Connected)
            {
                Console.WriteLine("disconnected with server");
            }

            Console.WriteLine("Connected?" + client.Connected);

            client.EmitAsync("join-room", deviceIdBox.Text);
        }
    }
}
