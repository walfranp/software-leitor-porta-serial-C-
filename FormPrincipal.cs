using System.IO.Ports;


namespace Porta_serial
{
    public partial class FormPrincipal : Form
    {
        public SerialPort _serialPort;
        public string _dataReceived = "";
        public FormPrincipal()
        {
            InitializeComponent();
            _serialPort = new SerialPort();
        }

        private void btnListarPortas_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.Clear();

            if (ports.Count() > 0)
            {
                foreach (string port in ports)
                {
                    cmbPorts.Items.Add(port);
                }

                cmbPorts.SelectedIndex = 0;
                btnOpen.Enabled = true;
            }
            else
            {
                MessageBox.Show("Não existem portas COM nesnte computador!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen == false)
            {
                try
                {
                    _serialPort.PortName = cmbPorts.Text;
                    _serialPort.BaudRate = 9600;
                    _serialPort.DataBits = 8;
                    _serialPort.Open();

                    btnOpen.Text = "Desconectar";
                    cmbPorts.Enabled = false;
                    btnListarPortas.Enabled = false;
                    statusStrip1.Items[0].Text = "Conectado!";
                    statusStrip1.Items[0].ForeColor = Color.Blue;
                    tbox_data.Clear();

                    _serialPort.DataReceived += _serialPort_DataReceived;
                }
                catch
                {
                    _serialPort.Close();
                    btnOpen.Text = "Conectar";
                    cmbPorts.Enabled = true;
                    btnListarPortas.Enabled = true;
                    statusStrip1.Items[0].Text = "Desconectado!";
                    statusStrip1.Items[0].ForeColor = Color.Red;

                    MessageBox.Show("Porta " + cmbPorts.Text + " ocupada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                _serialPort.Close();
                btnOpen.Text = "Conectar";
                cmbPorts.Enabled = true;
                btnListarPortas.Enabled = true;
                statusStrip1.Items[0].Text = "Desconectado!";
                statusStrip1.Items[0].ForeColor = Color.Red;
            }
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _dataReceived = _serialPort.ReadExisting();
            this.Invoke(new EventHandler(showData));
        }

        private void showData(object sender, EventArgs e)
        {
            tbox_data.Text += _dataReceived;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbox_data.Clear();
        }
    }
}