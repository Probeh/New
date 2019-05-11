namespace Server.Resources.DTOs.Request
{
    public class RequestDTO : BaseDTO
    {

    }
    public class RequestDTO<T> : RequestDTO where T : RequestDTO<T>
    {

    }
}