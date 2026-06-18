namespace CD.Domain.Clinic.ValueObjects
{
    public record Text
    {
        public string Value { get; init; }

        public Text(string value)
        {
            Validate(value);
            Value = value;
        }
        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Text cannot be null or empty.", nameof(value));
            if (value.Length > 500)
                throw new ArgumentException("Text cannot exceed 500 characters.", nameof(value));
        }

        public static implicit operator Text(string value)
        {
            return new Text(value);
        }
    }
}
