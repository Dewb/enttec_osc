//Linked2 Software (www.Linked2Software.com) Building Lighting Control Systems
//DMX-512 Test Application Visual Studio 2012 C#
//Written by Richard A. Blackwell with example source provided by Enttec.com
//
//This example uses only 3 channels by default which works fine with many simple RGB Lamps.
//
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

using SharpOSC;


namespace Enttec_Test
{

    public partial class Main : Form
    {
        UDPListener listener = null;
        Thread updateThread = null;
                
        Queue<OscMessage> messageQueue = new Queue<OscMessage>();

        TrackBar[] trackBars;
        Label[] labels;

        byte[] mostRecentData = new byte[8];
        System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();

        public Main()
        {
            InitializeComponent();

            trackBars = new TrackBar[]
            {
                trackBar1,
                trackBar2,
                trackBar3,
                trackBar4,
                trackBar5,
                trackBar6,
                trackBar7,
                trackBar8
            };

            labels = new Label[]
            {
                label1,
                label2,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10
            };

            HandleOscPacket callback = delegate(OscPacket packet)
            {
                if (packet is OscMessage)
                {
                    var msg = (OscMessage)packet;
                    if (msg.Address == "/dmx")
                    {
                        messageQueue.Enqueue(msg);
                    }
                }
                else if (packet is OscBundle)
                {
                    var bundle = (OscBundle)packet;
                    foreach (OscMessage msg in bundle.Messages)
                    {
                        if (msg.Address == "/dmx")
                        {
                            messageQueue.Enqueue(msg);
                        }
                    }
                }

                
            };

            updateThread = new Thread(delegate()
                {
                    OscMessage message;
                    while (true)
                    {
                        if (messageQueue.Count > 0)
                        {
                            message = messageQueue.Dequeue();
                            if (message != null && OpenDMX.status == FT_STATUS.FT_OK)
                            {


                                int channels = Math.Min(message.Arguments.Count, OpenDMX.UNIVERSE_SIZE);
                                for (int i = 0; i < channels; i++)
                                {
                                    try
                                    {
                                        float value = Convert.ToSingle(message.Arguments[i]);
                                        byte byteVal = (byte)(value * 255);
                                        OpenDMX.setDmxValue(i + 1, byteVal);

                                        mostRecentData[i] = byteVal;
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }

                                OpenDMX.streamData();

                            }
                        }
                    }
                }
            );
            updateThread.Start();

            listener = new UDPListener(7000, callback);

            refreshTimer.Interval = 500; //ms
            refreshTimer.Tick += new EventHandler(timer_Tick);
            refreshTimer.Start();

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                byte b = mostRecentData[i];
                if ((byte) trackBars[i].Value != b)
                {
                    setSlider(i, b);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                OpenDMX.start();                                            //find and connect to devive (first found if multiple)
                if ( OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)       //update status
                    toolStripStatusLabel1.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                    toolStripStatusLabel1.Text = "Found DMX on USB";
                else
                    toolStripStatusLabel1.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                toolStripStatusLabel1.Text = "Error Connecting to Enttec USB Device";

            }

            // On initialization, reset alll lights to zero
            OpenDMX.setDmxValue(1, 0);
            OpenDMX.setDmxValue(2, 0);
            OpenDMX.setDmxValue(3, 0);
            OpenDMX.setDmxValue(4, 0);
            OpenDMX.setDmxValue(5, 0);
            OpenDMX.setDmxValue(6, 0);
            OpenDMX.setDmxValue(7, 0);
            OpenDMX.setDmxValue(8, 0);
            OpenDMX.writeData();

            // For some reason we need duplication...
            OpenDMX.setDmxValue(1, 0);
            OpenDMX.setDmxValue(2, 0);
            OpenDMX.setDmxValue(3, 0);
            OpenDMX.setDmxValue(4, 0);
            OpenDMX.setDmxValue(5, 0);
            OpenDMX.setDmxValue(6, 0);
            OpenDMX.setDmxValue(7, 0);
            OpenDMX.setDmxValue(8, 0);
            OpenDMX.writeData();


            for (int i = 0; i < 8; i++)
            {
                mostRecentData[i] = 0;
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                toolStripStatusLabel1.Text = "No Enttec USB Device Found";
            else
                toolStripStatusLabel1.Text = "Found DMX on USB";
            OpenDMX.setDmxValue(1, 0);
            OpenDMX.setDmxValue(2, 0);
            OpenDMX.setDmxValue(3, 0);
            OpenDMX.setDmxValue(4, 0);
            OpenDMX.setDmxValue(5, 0);
            OpenDMX.setDmxValue(6, 0);
            OpenDMX.setDmxValue(7, 0);
            OpenDMX.setDmxValue(8, 0);
            OpenDMX.writeData();

            // For some reason we need duplication...
            OpenDMX.setDmxValue(1, 0);
            OpenDMX.setDmxValue(2, 0);
            OpenDMX.setDmxValue(3, 0);
            OpenDMX.setDmxValue(4, 0);
            OpenDMX.setDmxValue(5, 0);
            OpenDMX.setDmxValue(6, 0);
            OpenDMX.setDmxValue(7, 0);
            OpenDMX.setDmxValue(8, 0);
            OpenDMX.writeData();

            setSliders(0);

            for (int i = 0; i < 8; i++)
            {
                mostRecentData[i] = 0;
            }

        }

        private void btnAllOn_Click(object sender, EventArgs e)
        {
            if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                toolStripStatusLabel1.Text = "No Enttec USB Device Found";
            else
                toolStripStatusLabel1.Text = "Found DMX on USB";
            OpenDMX.setDmxValue(1, 255);
            OpenDMX.setDmxValue(2, 255);
            OpenDMX.setDmxValue(3, 255);
            OpenDMX.setDmxValue(4, 255);
            OpenDMX.setDmxValue(5, 255);
            OpenDMX.setDmxValue(6, 255);
            OpenDMX.setDmxValue(7, 255);
            OpenDMX.setDmxValue(8, 255);
            OpenDMX.writeData();

            // For some reason we need duplication...
            OpenDMX.setDmxValue(1, 255);
            OpenDMX.setDmxValue(2, 255);
            OpenDMX.setDmxValue(3, 255);
            OpenDMX.setDmxValue(4, 255);
            OpenDMX.setDmxValue(5, 255);
            OpenDMX.setDmxValue(6, 255);
            OpenDMX.setDmxValue(7, 255);
            OpenDMX.setDmxValue(8, 255);
            OpenDMX.writeData();

            setSliders(255);

            for (int i = 0; i < 8; i++)
            {
                mostRecentData[i] = 255;
            }
        }

        private void setSlider(int id, int val)
        {
            if (val > 255)
                val = 255;
            else if (val < 0)
                val = 0;

            trackBars[id].Value = val;
            labels[id].Text = "" + val;
        }

        private void setSliders(int val)
        {
            for (int i = 0; i < 8; i++)
            {
                setSlider(i, val);
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "" + trackBar1.Value;
            OpenDMX.setDmxValue(1, (byte)trackBar1.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(1, (byte)trackBar1.Value);
            OpenDMX.writeData();
            mostRecentData[0] = (byte) trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "" + trackBar2.Value;
            OpenDMX.setDmxValue(2, (byte)trackBar2.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(2, (byte)trackBar2.Value);
            OpenDMX.writeData();
            mostRecentData[1] = (byte)trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label5.Text = "" + trackBar3.Value;
            OpenDMX.setDmxValue(3, (byte)trackBar3.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(3, (byte)trackBar3.Value);
            OpenDMX.writeData();
            mostRecentData[2] = (byte)trackBar3.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label6.Text = "" + trackBar4.Value;
            OpenDMX.setDmxValue(4, (byte)trackBar4.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(4, (byte)trackBar4.Value);
            OpenDMX.writeData();
            mostRecentData[3] = (byte)trackBar4.Value;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label7.Text = "" + trackBar5.Value;
            OpenDMX.setDmxValue(5, (byte)trackBar5.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(5, (byte)trackBar5.Value);
            OpenDMX.writeData();
            mostRecentData[4] = (byte)trackBar5.Value;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label8.Text = "" + trackBar6.Value;
            OpenDMX.setDmxValue(6, (byte)trackBar6.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(6, (byte)trackBar6.Value);
            OpenDMX.writeData();
            mostRecentData[5] = (byte)trackBar6.Value;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label9.Text = "" + trackBar7.Value;
            OpenDMX.setDmxValue(7, (byte)trackBar7.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(7, (byte)trackBar7.Value);
            OpenDMX.writeData();
            mostRecentData[6] = (byte)trackBar7.Value;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            label10.Text = "" + trackBar8.Value;
            OpenDMX.setDmxValue(8, (byte)trackBar8.Value);
            OpenDMX.writeData();
            OpenDMX.setDmxValue(8, (byte)trackBar8.Value);
            OpenDMX.writeData();
            mostRecentData[7] = (byte)trackBar8.Value;
        }

    }


    public class OpenDMX
    {
        public static int UNIVERSE_SIZE = 8;

        public static byte[] buffer = new byte[UNIVERSE_SIZE + 1];
        public static uint handle;
        public static bool done = false;
        public static bool Connected = false;
        public static int bytesWritten = 0;
        public static FT_STATUS status;

        public const byte BITS_8 = 8;
        public const byte STOP_BITS_2 = 2;
        public const byte PARITY_NONE = 0;
        public const UInt16 FLOW_NONE = 0;
        public const byte PURGE_RX = 1;
        public const byte PURGE_TX = 2;


        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_Open(UInt32 uiPort, ref uint ftHandle);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_Close(uint ftHandle);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_Read(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesReturned);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_Write(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesWritten);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_SetDataCharacteristics(uint ftHandle, byte uWordLength, byte uStopBits, byte uParity);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_SetFlowControl(uint ftHandle, char usFlowControl, byte uXon, byte uXoff);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_GetModemStatus(uint ftHandle, ref UInt32 lpdwModemStatus);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_Purge(uint ftHandle, UInt32 dwMask);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_ClrRts(uint ftHandle);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_SetBreakOn(uint ftHandle);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_SetBreakOff(uint ftHandle);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_GetStatus(uint ftHandle, ref UInt32 lpdwAmountInRxQueue, ref UInt32 lpdwAmountInTxQueue, ref UInt32 lpdwEventStatus);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_ResetDevice(uint ftHandle);
        [DllImport("FTD2XX.dll")]
        public static extern FT_STATUS FT_SetDivisor(uint ftHandle, char usDivisor);


        public static void start()
        {
            handle = 0;
            status = FT_Open(0, ref handle);
                //setting up the WriteData method to be on it's own thread. This will also turn all channels off
                //this unrequested change of state can be managed by getting the current state of all channels 
                //into the write buffer before calling this function.
            Thread thread = new Thread(new ThreadStart(writeData));
            thread.Start();
        }

        public static void setDmxValue(int channel, byte value)
        {
            if (buffer != null)
            {
                buffer[channel ] = value;
            }
        }

        public static void streamData()
        {
            status = FT_SetBreakOn(handle);
            status = FT_SetBreakOff(handle);
            bytesWritten = write(handle, buffer, buffer.Length);
            Thread.Sleep(8);
            status = FT_SetBreakOn(handle);
            status = FT_SetBreakOff(handle);
            bytesWritten = write(handle, buffer, buffer.Length);
            Thread.Sleep(8);
        }

        public static void  writeData()
        {
                try
                {
                    initOpenDMX();
                    if (OpenDMX.status == FT_STATUS.FT_OK)
                    {
                        status = FT_SetBreakOn(handle);
                        status = FT_SetBreakOff(handle);
                        bytesWritten = write(handle, buffer, buffer.Length);

                        Thread.Sleep(25);      //give the system time to send the data before sending more 
                        
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }

        }

        public static int write(uint handle, byte[] data, int length)
        {
            try
            {
                IntPtr ptr = Marshal.AllocHGlobal((int)length);
                Marshal.Copy(data, 0, ptr, (int)length);
                uint bytesWritten = 0;
                status = FT_Write(handle, ptr, (uint)length, ref bytesWritten);
                return (int)bytesWritten;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                return 0;
            }
        }

        public static void initOpenDMX()
        {
            status = FT_ResetDevice(handle);
            status = FT_SetDivisor(handle, (char)12);  // set baud rate
            status = FT_SetDataCharacteristics(handle, BITS_8, STOP_BITS_2, PARITY_NONE);
            status = FT_SetFlowControl(handle, (char)FLOW_NONE, 0, 0);
            status = FT_ClrRts(handle);
            status = FT_Purge(handle, PURGE_TX);
            status = FT_Purge(handle, PURGE_RX);
        }

    }

    /// <summary>
    /// Enumaration containing the varios return status for the DLL functions.
    /// </summary>
    public enum FT_STATUS
    {
        FT_OK = 0,
        FT_INVALID_HANDLE,
        FT_DEVICE_NOT_FOUND,
        FT_DEVICE_NOT_OPENED,
        FT_IO_ERROR,
        FT_INSUFFICIENT_RESOURCES,
        FT_INVALID_PARAMETER,
        FT_INVALID_BAUD_RATE,
        FT_DEVICE_NOT_OPENED_FOR_ERASE,
        FT_DEVICE_NOT_OPENED_FOR_WRITE,
        FT_FAILED_TO_WRITE_DEVICE,
        FT_EEPROM_READ_FAILED,
        FT_EEPROM_WRITE_FAILED,
        FT_EEPROM_ERASE_FAILED,
        FT_EEPROM_NOT_PRESENT,
        FT_EEPROM_NOT_PROGRAMMED,
        FT_INVALID_ARGS,
        FT_OTHER_ERROR
    };


}
