using System.Text.Json;
using System.IO;

public class WeaponLocker
{
    public List<Weapon> weapons = new();

    // public List<String> Weapons = new List<string>() { "Toz-106", "VPO-209", "MP-133", "Kedr-B", "AKS-74U", "SVDS", "AKMN", "VPO-215", "SA-58 / FAL" };

    public WeaponLocker()
    {
        string json = File.ReadAllText("weapons.json");
        weapons = JsonSerializer.Deserialize<List<Weapon>>(json);

        Console.WriteLine(weapons.Count);
    }

    public Weapon GimmeRandom()
    {
        return weapons[new Random().Next(weapons.Count)];
    }
}
