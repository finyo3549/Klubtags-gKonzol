using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Klubtagság
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string endpointUrl = "https://retoolapi.dev/OEDUXm/member";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(endpointUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Member[] members = JsonSerializer.Deserialize<Member[]>(responseBody);

                        int tagokSzama = members.Length;
                        Console.WriteLine($"Hány tag van: {tagokSzama}");

                        String utoljaraBelepettNev  = utoljaraBelepett(members);
                        Console.WriteLine($"Ki lépett be legutoljára: {utoljaraBelepettNev}");

                        var erdeklodesiKorok = Erdeklodes(members);
                        foreach (var erdeklodesikor in erdeklodesiKorok)
                        {
                            Console.WriteLine($"Érdeklődési kör: {erdeklodesikor.Key}, Tagok száma: {erdeklodesikor.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Hiba történt a végpont elérésénél: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }

            Console.ReadLine();
        }

        static Dictionary<string, int> Erdeklodes(Member[] members)
        {
            var szamol = new Dictionary<string, int>();

            foreach (var member in members)
            {
                if (!szamol.ContainsKey(member.Interest))
                {
                    szamol[member.Interest] = 0;
                }
                szamol[member.Interest]++;
            }

            return szamol;
        }
        static string utoljaraBelepett(Member[] members)
        {
            Member utoljaraBelepett = members[0];
            foreach (var member in members)
            {
                if (member.Entry > utoljaraBelepett.Entry)
                {
                    utoljaraBelepett = member;
                }
                
            }
            return utoljaraBelepett.Fullname;
        }
    }
}
