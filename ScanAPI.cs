using Symbol.Barcode2;

namespace CS_Barcode2ControlSample1
{
    internal class ScanAPI
    {
        private Barcode2 _myBarcode2;

        public Barcode2 Barcode2
        {
            get { return _myBarcode2; }
        }

        public bool InitBarcode()
        {
            if (_myBarcode2 != null)
            {
                return false;
            }
            Device myDevice = Devices.SupportedDevices[0];
            try
            {
                if (myDevice == null)
                {
                    return false;
                }
                _myBarcode2 = new Barcode2(myDevice);
                switch (_myBarcode2.Config.Reader.ReaderType)
                {
                    case READER_TYPES.READER_TYPE_IMAGER:
                        _myBarcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER;
                        break;
                    case READER_TYPES.READER_TYPE_LASER:
                        _myBarcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER;
                        break;
                }
                _myBarcode2.Config.Reader.ReaderSpecific.LaserSpecific.LinearSecurityLevel = LINEAR_SECURITY_LEVEL.SECURITY_ALL_TWICE;
                _myBarcode2.Config.Reader.Set();
                _myBarcode2.Config.Decoders.I2OF5.Enabled = true;
                _myBarcode2.Config.Decoders.CODE128.Enabled = true; //
                _myBarcode2.Config.Decoders.I2OF5.MinLength = 10;
                _myBarcode2.Config.Decoders.I2OF5.MaxLength = 26;
                _myBarcode2.Config.Decoders.I2OF5.Redundancy = true;
                _myBarcode2.Config.Decoders.Set();
                _myBarcode2.Config.Scanner.DecodeBeepTime = 100;
                _myBarcode2.Config.Scanner.DecodeBeepFrequency = 4000;
                _myBarcode2.Config.Scanner.Set();
                

               // _myBarcode2.Config.Reader.ReaderSpecific.ImagerSpecific.
              //  _myBarcode2.Config.Read
                    
            }
            catch (OperationFailureException ex)
            {
                // MessageBox.Show(Resources.GetString("InitBarcode") + "\n" +Resources.GetString("OperationFailure") + "\n" + ex.Message +"\n" +Resources.GetString("Result") + " = " + (Results)((uint)ex.Result));
                return false;
            }
            catch (InvalidRequestException ex)
            {
                // MessageBox.Show(Resources.GetString("InitBarcode") + "\n" +Resources.GetString("InvalidRequest") + "\n" +ex.Message);
                return false;
            }
            catch (InvalidIndexerException ex)
            {
                // MessageBox.Show(Resources.GetString("InitBarcode") + "\n" +Resources.GetString("InvalidIndexer") + "\n" +ex.Message);
                return false;
            }
            return true;
        }

        public void TermBarcode()
        {
            if (_myBarcode2 != null)
            {
                try
                {
                    StopScan();
                    _myBarcode2.Dispose();
                    _myBarcode2 = null;
                }
                catch (OperationFailureException ex)
                {
                    // MessageBox.Show(Resources.GetString("TermBarcode") + "\n" +Resources.GetString("OperationFailure") + "\n" + ex.Message +"\n" +Resources.GetString("Result") + " = " + (Results)((uint)ex.Result));
                }
                catch (InvalidRequestException ex)
                {
                    // MessageBox.Show(Resources.GetString("TermBarcode") + "\n" +Resources.GetString("InvalidRequest") + "\n" +ex.Message);
                }
                catch (InvalidIndexerException ex)
                {
                    // MessageBox.Show(Resources.GetString("TermBarcode") + "\n" +Resources.GetString("InvalidIndexer") + "\n" +ex.Message);
                }
                ;
            }
        }

        public void StartScan(bool triggerSoftAlways)
        {
            if (_myBarcode2 == null) return;
            try
            {
                if (triggerSoftAlways)
                {
                    //if (_myBarcode2.Config.TriggerMode != TRIGGERMODES.SOFT_ALWAYS)
                    _myBarcode2.Config.TriggerMode = TRIGGERMODES.SOFT_ALWAYS;
                }
                else
                {
                    _myBarcode2.Config.TriggerMode = TRIGGERMODES.HARD;
                }
                _myBarcode2.Config.ScanDataSize = (int)(ReaderDataLengths.MaximumLabel);
                _myBarcode2.Scan(5000);
            }
            catch (Symbol.Exceptions.OperationFailureException ex)
            {
                // MessageBox.Show(Resources.GetString("StartScan") + "\n" +Resources.GetString("OperationFailure") + "\n" + ex.Message +"\n" +Resources.GetString("Result") + " = " + (Symbol.Results)((uint)ex.Result));
            }
            catch (Symbol.Exceptions.InvalidRequestException ex)
            {
                // MessageBox.Show(Resources.GetString("StartScan") + "\n" +Resources.GetString("InvalidRequest") + "\n" +ex.Message);
            }
            catch (Symbol.Exceptions.InvalidIndexerException ex)
            {
                // MessageBox.Show(Resources.GetString("StartScan") + "\n" +Resources.GetString("InvalidIndexer") + "\n" +ex.Message);
            }
        }

        public void StopScan()
        {
            if (_myBarcode2 == null) return;
            try
            {
                _myBarcode2.ScanCancel();
            }
            catch (OperationFailureException ex)
            {
                // MessageBox.Show(Resources.GetString("StopScan") + "\n" +Resources.GetString("OperationFailure") + "\n" + ex.Message +"\n" +Resources.GetString("Result") + " = " + (Results)((uint)ex.Result));
            }
            catch (InvalidRequestException ex)
            {
                // MessageBox.Show(Resources.GetString("StopScan") + "\n" +Resources.GetString("InvalidRequest") + "\n" +ex.Message);
            }
            catch (InvalidIndexerException ex)
            {
                // MessageBox.Show(Resources.GetString("StopScan") + "\n" +Resources.GetString("InvalidIndexer") + "\n" +ex.Message);
            }
            ;
        }


        public void AttachScanNotify(Barcode2.OnScanHandler scanNotifyHandler)
        {
            if (_myBarcode2 == null) return;
            _myBarcode2.OnScan += scanNotifyHandler;
        }

        public void DetachScanNotify(Barcode2.OnScanHandler scanNotifyHandler)
        {
            if (_myBarcode2 == null) return;
            _myBarcode2.OnScan -= scanNotifyHandler;
        }

        public void AttachStatusNotify(Barcode2.OnStatusHandler statusNotifyHandler)
        {
            if (_myBarcode2 == null) return;
            _myBarcode2.OnStatus += statusNotifyHandler;
        }

        public void DetachStatusNotify(Barcode2.OnStatusHandler statusNotifyHandler)
        {
            if (_myBarcode2 == null) return;
            _myBarcode2.OnStatus -= statusNotifyHandler;
        }
    }
}
