namespace Store.Application.Dto
{
    public class BaseDto
    {
        public string _Message { get; set; }
        public object _Data { get; set; }
        public bool _Condition { get; set; }

        public BaseDto(string message, object data, bool condition)
        {
            _Message = message;
            _Data = data;
            _Condition = condition;
        }

        public BaseDto(string message, bool condition)
        {
            _Message = message;
            _Condition = condition;
        }
    }
}