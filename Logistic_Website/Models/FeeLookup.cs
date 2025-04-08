namespace Logistic_Website.Models;

public class FeeLookup
{
    public string Name { get; set; }
    public TerminalHandlingCharge THC { get; set; }
    public DeliveryOrderFee DOFee { get; set; }
    public string SealFee { get; set; }
    public string ManifestSubmissionFee { get; set; }
    public string BLAmendmentFee { get; set; }
    public string LatePayment { get; set; }
}

public class DeliveryOrderFee
{
    public string Manual { get; set; }
    public string Electric { get; set; }
    public bool IsMerge => string.IsNullOrEmpty(Manual) && string.IsNullOrEmpty(Electric);
    public string MergeFee { get; set; }
}

public class TerminalHandlingCharge
{
    public string DC20 { get; set; }
    public string DC40 { get; set; }
    public string DC45 { get; set; }
    public string RFFLOT20 { get; set; }
    public string RFFLOT40 { get; set; }
}
