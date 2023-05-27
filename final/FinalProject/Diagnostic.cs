public class Diagnostic : IDataSL{
    private List<string> _reports;
    private Pet _patient;
    private DateOnly _date;
    private int _severity;
    private Vet _vet;

    public void AddReport(string report){
        _reports.Add(report);
    }

    string IDataSL.StringRepresentation(){
        throw new NotImplementedException();
    }
}