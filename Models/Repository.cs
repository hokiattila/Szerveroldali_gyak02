using System.Xml.Serialization;

namespace Szerveroldali_gyak02.Models
{
    public static class Repository
    {
        private static List<GuestResponse> _response = new();

        public static IEnumerable<GuestResponse> Response { get { return _response; } }

        public static void AddResponse(GuestResponse response)
        {
            _response.Add(response);
        }

    }
}
