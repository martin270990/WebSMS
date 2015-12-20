using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Collections;

namespace WebSMS
{
    class Ports
    {
        SerialPort puerto = new SerialPort(); // Crea nuevo objeto
        
        
        //Metodo para abrir el puerto segun el COM y lo llama los valores por defecto en donde se le asigna lo que corresponde y llama al metodo
        // Puerto.Open();
        public void AbrirPuertoSerie()
        {
            try
            {
                if (puerto.IsOpen == true)
                {
                    puerto.Close();
                }
                else
                {
                    
                    PuertosInicialDefault("COM5");
                }
            }
           catch (Exception error)
            {
               error.ToString();
            }
        }

        public void cerrarpuert()
        {
            puerto.Close();

        }
        
        /*
         Método para obtener los puertos COM de la PC. Los enlista en el objeto #PuertoSerie
         */
        public ArrayList ObtenerPuertosPC()
        {
            ArrayList PuertosSerie = new ArrayList(); //Permite listar los puertos
            try
            {
                foreach (string PuertoObtenido in SerialPort.GetPortNames())
                {
                    PuertosSerie.Add(PuertoObtenido);
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
            return PuertosSerie;
        }

        //Metodo que inicia los valores del puerto
        public void PuertosInicialDefault(string portCom)
        {
            puerto.PortName = portCom;
            puerto.BaudRate = 9600;
            puerto.DataBits = 8;
            puerto.Parity = Parity.None;
            puerto.StopBits = StopBits.One;
            puerto.Handshake = Handshake.None;
            puerto.DtrEnable = false;
            puerto.ReadBufferSize = 1024;
            puerto.WriteBufferSize = 1024;
            puerto.WriteTimeout = 500;
            puerto.RtsEnable = true;
            puerto.Encoding = Encoding.Default;
            puerto.Open();

        }


        // Envia el mensaje
        public int enviarMensaje(string num, string msg)
        {
            
                //Poner AT en modo texto
                puerto.Write("at+cmgf=1" + Convert.ToChar(13));
                System.Threading.Thread.Sleep(1000);
                //Poner modo GSM para que admita simbolos
                puerto.Write("AT+CSCS=" + "\"GSM" + "\"" + Convert.ToChar(13));
                System.Threading.Thread.Sleep(1000);
                puerto.Write("AT+CMGS=" + Convert.ToChar(34) + num + Convert.ToChar(34) + Convert.ToChar(13));
                System.Threading.Thread.Sleep(1000);
                puerto.Write(msg + Convert.ToChar(26));
                System.Threading.Thread.Sleep(2000);
                if (puerto.ReadExisting().IndexOf("OK")>0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
        }

        //Leer SMS Entrantes:
        public ArrayList leerMensajes()
        {
            string msgReceive = "";
            int cant = 0;
            ArrayList msg = new ArrayList();
            puerto.Write("AT+CMGF=1" + Convert.ToChar(13));
            Thread.Sleep(99);
            msgReceive = puerto.ReadExisting();
            if (msgReceive.IndexOf("OK") > 0)
            {
                while (msgReceive.IndexOf("OK") > 0)
                {
                    puerto.Write(("AT+CMGR=" + cant) + Convert.ToChar(13));
                    Thread.Sleep(99);
                    msgReceive = puerto.ReadExisting();
                    msg.Add(msgReceive);
                    cant++;

                }
                
            }

            return msg;
        }


        
        // Lee imei del modem
        public String imeiModem()
        {
            puerto.Write("AT+CGSN" + Convert.ToChar(13));
            System.Threading.Thread.Sleep(1000);
            String numImei = puerto.ReadExisting();
            numImei = numImei.Replace("AT+CGSN", "");
            numImei = numImei.Replace("\r", "");
            numImei = numImei.Replace("OK", "");
            numImei = numImei.Replace("\n", "");
            return numImei;
        }

        // Lee señal del modem
            public String signalModem()

            {    puerto.Write("AT+CSQ" + Convert.ToChar(13));
                 System.Threading.Thread.Sleep(1000);
                 String numSignal = puerto.ReadExisting();
                 numSignal = numSignal.Replace("AT+CSQ", "");
                 numSignal = numSignal.Replace("\r", "");
                 numSignal = numSignal.Replace("+CSQ: ", "");
                 numSignal = numSignal.Replace("OK", "");
                 numSignal = numSignal.Replace("\n", "");
                 return numSignal;
            }
            
        
        }


    }
