// Very lazy program. Just made to fit purpose.
string location = Directory.GetCurrentDirectory() + @"\Location.txt";
string locationValorant = "";
string locationOutplayed = "";
string configValorant = "";
string configOutplayed = "";


// Load file stuff
try {
    string[] launchSettings = File.ReadAllLines(location);
    locationValorant = launchSettings[0].Substring(launchSettings[0].IndexOf(':') + 1).Trim();
    locationOutplayed = launchSettings[1].Substring(launchSettings[1].IndexOf(':') + 1).Trim();
    configValorant = launchSettings[2].Substring(launchSettings[2].IndexOf(':') + 1).Trim();
    configOutplayed = launchSettings[3].Substring(launchSettings[3].IndexOf(':') + 1).Trim();
}
catch {
    if (!Directory.Exists(location)) 
        File.WriteAllText(location, "Valorant: \nOutplayed: \nValorantArgs: \nOutplayedArgs: ");
    
    Console.WriteLine($"Please go to {location} and fill out the details there.");
    Console.ReadLine();
    Environment.Exit(0);
}

try {
    Console.WriteLine("Launching Valorant...");
    System.Diagnostics.Process.Start(locationValorant, configValorant);
}
catch {
    Console.WriteLine("Valorant Failed to load. Press enter to exit...");
    Console.ReadLine();
    Environment.Exit(0);
}
try {
    Console.WriteLine("Launching Outplayed...");
    System.Diagnostics.Process.Start(locationOutplayed, configOutplayed);
    Console.WriteLine("Success");
    Environment.Exit(0);
}
catch {
    Console.WriteLine("Outplayed Failed to load. Press enter to exit...");
    Console.ReadLine();
    Environment.Exit(0);
}
