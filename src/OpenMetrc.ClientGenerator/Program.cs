using OpenMetrc.ClientGenerator;

var metrcFiles = Directory.EnumerateFiles("../../../../../", "open-metrc-*.yaml", SearchOption.AllDirectories);
foreach (var metrcFile in metrcFiles) await GeneratorService.CreateClientClass(metrcFile);