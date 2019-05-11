namespace Server.Resources.DTOs.Response
{
    public class ResponseDTO : BaseDTO
    {

    }
    public class ResponseDTO<T> : ResponseDTO where T : ResponseDTO<T>
    {

    }
}