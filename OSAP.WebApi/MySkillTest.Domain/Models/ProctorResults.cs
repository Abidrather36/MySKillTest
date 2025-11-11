namespace OSAP.WebApi.Models
{
    public class ProctorResults
    {
        public string identifier { get; set; }
        public string link { get; set; }
        public string status { get; set; }
        public string duration { get; set; }
        public string startedAt { get; set; }
        public string stoppedAt { get; set; }
        public string score { get; set; }
        public string student { get; set; }
        public string signedAt { get; set; }
        public string conclusion { get; set; }
        public Averages averages { get; set; }
        public string verified { get; set; }
        public byte[] PDFFileData { get; set; }
    }

    public class Averages
    {
        public string b1 { get; set; }
        public string b2 { get; set; }
        public string b3 { get; set; }
        public string c1 { get; set; }
        public string c2 { get; set; }
        public string c3 { get; set; }
        public string c4 { get; set; }
        public string c5 { get; set; }
        public string k1 { get; set; }
        public string m1 { get; set; }
        public string m2 { get; set; }
        public string n1 { get; set; }
        public string n2 { get; set; }
        public string s1 { get; set; }
        public string s2 { get; set; }
    }
}