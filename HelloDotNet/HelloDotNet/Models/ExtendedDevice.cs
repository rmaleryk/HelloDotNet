namespace HelloDotNet.Models
{
    public class ExtendedDevice : Device
    {
        protected override int InternalType => 5;

        private string GetInternalIdentifier()
        {
            return $"{Identifier}_{InternalType}";
        }
    }
}
