namespace AlphabiApi.Compartilhado
{
    public class Response
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public object Data { get; private set; }

        private Response(bool success) => Success = success;
        public static Response OK() => new Response(true);
        public static Response Fail() => new Response(false);
        public Response WithMessage(string message) { Message = message; return this; }
        public Response WithData(object data) { Data = data; return this; }
        public T GetData<T>()
        {
            return (T)Data;
        }
    }
}
