using System;
using System.Collections.Generic;

namespace T03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int neededValue = 250;
            Dictionary<string, int> specialMaterials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            string information;

            while (true)
            {
                information = Console.ReadLine().ToLower();
                string[] materials = information.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool isSpecialItemObtained = false;
                for (int i = 0; i < materials.Length; i += 2)
                {
                    int materialQuantity = int.Parse(materials[i]);
                    string materialName = materials[i + 1];

                    if (!specialMaterials.ContainsKey(materialName))
                    {
                        //the material is junk
                        if (!junkMaterials.ContainsKey(materialName))
                        {
                            junkMaterials.Add(materialName, 0);
                        }

                        junkMaterials[materialName] += materialQuantity;
                    }
                    else
                    {
                        //material is special
                        specialMaterials[materialName] += materialQuantity;
                        if (materialName == "shards" && specialMaterials[materialName] >= neededValue)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            specialMaterials[materialName] -= neededValue;
                            isSpecialItemObtained = true;
                            break;
                        }
                        else if (materialName == "motes" && specialMaterials[materialName] >= neededValue)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            specialMaterials[materialName] -= neededValue;
                            isSpecialItemObtained = true;
                            break;
                        }
                        else if (materialName == "fragments" && specialMaterials[materialName] >= neededValue)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            specialMaterials[materialName] -= neededValue;
                            isSpecialItemObtained = true;
                            break;
                        }
                    }
                }
                if (isSpecialItemObtained)
                {
                    //printing the special materials
                    foreach (var specialMaterial in specialMaterials)
                    {
                        Console.WriteLine($"{specialMaterial.Key}: {specialMaterial.Value}");
                    }

                    //printing the junk materials
                    foreach (var junkMaterial in junkMaterials)
                    {
                        Console.WriteLine($"{junkMaterial.Key}: {junkMaterial.Value}");
                    }

                    break;
                }
            }
        }
    }
}
