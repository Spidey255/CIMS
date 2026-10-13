namespace CPS.Proof.DFSExtension
{
    public interface IRestExecutor
    {
        Status ExecuteRest(HttpRequest request, out string response);
    }
}
