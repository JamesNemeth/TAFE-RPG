using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemId)
    {
        string name = "";
        string description = "";
        int amount = 0;
        int value = 0;
        int damage = 0;
        int armour = 0;
        int heal = 0;
        string iconName = "";
        string meshName = "";
        ItemTypes type = ItemTypes.Misc;

        switch (itemId)
        {
            #region Armour 0-99
            case 0:
                name = "Leather Chestplate";
                description = "Is light but doesn't leave you with much defense";
                amount = 1;
                value = 50;
                damage = 0;
                armour = 8;
                heal = 0;
                iconName = "Armour/Leather Chestplate";
                meshName = "Armour/Leather Chestplate";
                type = ItemTypes.Armour;
                break;
            case 1:
                name = "Leather Boots";
                description = "Have a little of protection for you feet";
                amount = 1;
                value = 15;
                damage = 0;
                armour = 3;
                heal = 0;
                iconName = "Armour/Leather Boots";
                meshName = "Armour/Leather Boots";
                type = ItemTypes.Armour;
                break;
            case 2:
                name = "Leather Leggings";
                description = "Protect your beautiful legs with these";
                amount = 1;
                value = 30;
                damage = 0;
                armour = 5;
                heal = 0;
                iconName = "Armour/Leather Leggings";
                meshName = "Armour/Leather Leggings";
                type = ItemTypes.Armour;
                break;
            case 3:
                name = "Iron Chestplate";
                description = "The best defensive item you can find anywhere";
                amount = 1;
                value = 250;
                damage = 0;
                armour = 25;
                heal = 0;
                iconName = "Armour/Iron Chestplate";
                meshName = "Armour/Iron Chestplate";
                type = ItemTypes.Armour;
                break;
            case 4:
                name = "Iron Boots";
                description = "Show off your impressive foot wear with these";
                amount = 1;
                value = 100;
                damage = 0;
                armour = 10;
                heal = 0;
                iconName = "Armour/Iron Boots";
                meshName = "Armour/Iron Boots";
                type = ItemTypes.Armour;
                break;
            case 5:
                name = "Iron Leggings";
                description = "";
                amount = 1;
                value = 100;
                damage = 0;
                armour = 10;
                heal = 0;
                iconName = "Armour/Iron Leggings";
                meshName = "Armour/Iron Leggings";
                type = ItemTypes.Armour;
                break;
            case 6:
                name = "Leather Helmet";
                description = "Will do the job";
                amount = 1;
                value = 20;
                damage = 0;
                armour = 4;
                heal = 0;
                iconName = "Armour/Leather Helmet";
                meshName = "Armour/Leather Helmet";
                type = ItemTypes.Armour;
                break;
            #endregion
            #region Weapon 100-199
            case 100:
                name = "Iron Sword";
                description = "";
                amount = 1;
                value = 100;
                damage = 20;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Iron Sword";
                meshName = "Weapons/Iron Sword";
                type = ItemTypes.Weapon;
                break;
            case 101:
                name = "Dagger";
                description = "";
                amount = 1;
                value = 50;
                damage = 14;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Dagger";
                meshName = "Weapons/Dagger";
                type = ItemTypes.Weapon;
                break;
            case 102:
                name = "Axe";
                description = "";
                amount = 1;
                value = 100;
                damage = 20;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Axe";
                meshName = "Weapons/Axe";
                type = ItemTypes.Weapon;
                break;
            case 103:
                name = "Mace";
                description = "";
                amount = 1;
                value = 100;
                damage = 20;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Mace";
                meshName = "Weapons/Mace";
                type = ItemTypes.Weapon;
                break;
            case 104:
                name = "Bow";
                description = "";
                amount = 1;
                value = 100;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Bow";
                meshName = "Weapons/Bow";
                type = ItemTypes.Weapon;
                break;
            #endregion
            #region Potion 200-299
            case 200:
                name = "Health Potion";
                description = "";
                amount = 1;
                value = 150;
                damage = 0;
                armour = 0;
                heal = 50;
                iconName = "Potions/Health Potion";
                meshName = "Potions/Health Potion";
                type = ItemTypes.Potion;
                break;
            case 201:
                name = "Mana Potion";
                description = "";
                amount = 1;
                value = 150;
                damage = 0;
                armour = 0;
                heal = 50;
                iconName = "Potions/Mana Potion";
                meshName = "Potions/Mana Potion";
                type = ItemTypes.Potion;
                break;
            case 202:
                name = "Stamina Potion";
                description = "";
                amount = 1;
                value = 150;
                damage = 0;
                armour = 0;
                heal = 50;
                iconName = "Potions/Stamina Potion";
                meshName = "Potions/Stamina Potion";
                type = ItemTypes.Potion;
                break;
            #endregion
            #region Food 300-399
            case 300:
                name = "Apple";
                description = "Munchies and Crunchies";
                amount = 1;
                value = 1;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Food;
                break;
            case 301:
                name = "Meat";
                description = "A little chewy but still tasty";
                amount = 1;
                value = 5;
                damage = 0;
                armour = 0;
                heal = 5;
                iconName = "Food/Meat";
                meshName = "Food/Meat";
                type = ItemTypes.Food;
                break;
            #endregion
            #region Ingredient 400-499
            case 400:
                name = "Red Mushroom";
                description = "";
                amount = 5;
                value = 10;
                damage = 0;
                armour = 0;
                heal = -5;
                iconName = "Craftables/Red Mushroom";
                meshName = "Craftables/Red Mushroom";
                type = ItemTypes.Ingredient;
                break;
            case 401:
                name = "Blue Mushroom";
                description = "";
                amount = 5;
                value = 10;
                damage = 0;
                armour = 0;
                heal = -5;
                iconName = "Craftables/Blue Mushroom";
                meshName = "Craftables/Blue Mushroom";
                type = ItemTypes.Ingredient;
                break;
            case 402:
                name = "Brown Mushroom";
                description = "";
                amount = 5;
                value = 10;
                damage = 0;
                armour = 0;
                heal = -5;
                iconName = "Craftables/Brown Mushroom";
                meshName = "Craftables/Brown Mushroom";
                type = ItemTypes.Ingredient;
                break;
            case 403:
                name = "Peas";
                description = "";
                amount = 5;
                value = 15;
                damage = 0;
                armour = 0;
                heal = 5;
                iconName = "Craftables/Peas";
                meshName = "Craftables/Peas";
                type = ItemTypes.Ingredient;
                break;
            case 404:
                name = "Acorn";
                description = "";
                amount = 5;
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftables/Acorn";
                meshName = "Craftables/Acorn";
                type = ItemTypes.Ingredient;
                break;
            #endregion
            #region Craftable 500-599
            case 500:
                name = "Flail";
                description = "";
                amount = 1;
                value = 200;
                damage = 20;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Flail";
                meshName = "Weapons/Flail";
                type = ItemTypes.Weapon;
                break;
            case 501:
                name = "Dragon Axe";
                description = "";
                amount = 1;
                value = 500;
                damage = 30;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Dragon Axe";
                meshName = "Weapons/Dragon Axe";
                type = ItemTypes.Weapon;
                break;
            case 502:
                name = "Mini Axe";
                description = "";
                amount = 1;
                value = 300;
                damage = 25;
                armour = 0;
                heal = 0;
                iconName = "Weapons/Mini Axe";
                meshName = "Weapons/Mini Axe";
                type = ItemTypes.Weapon;
                break;
            #endregion
            #region Quest 600-699
            case 600:
                name = "Obsidian";
                description = "";
                amount = 1;
                value = 300;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/Obsidian";
                meshName = "Quest/Obsidian";
                type = ItemTypes.Quest;
                break;
            case 601:
                name = "Water Stone";
                description = "";
                amount = 1;
                value = 300;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/Water Stone";
                meshName = "Quest/Water Stone";
                type = ItemTypes.Quest;
                break;
            case 602:
                name = "Fire Stone";
                description = "";
                amount = 1;
                value = 300;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/Fire Stone";
                meshName = "Quest/Fire Stone";
                type = ItemTypes.Quest;
                break;
            case 603:
                name = "Lighting Orb";
                description = "";
                amount = 1;
                value = 300;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/Lighting Orb";
                meshName = "Quest/Lighting Orb";
                type = ItemTypes.Quest;
                break;
            case 604:
                name = "Crystallised Ember";
                description = "";
                amount = 1;
                value = 300;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/Crystallised Ember";
                meshName = "Quest/Crystallised Ember";
                type = ItemTypes.Quest;
                break;
            #endregion
            #region Misc 700-799
            case 700:
                name = "Iron Ingot";
                description = "";
                amount = 1;
                value = 25;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/Iron Ingot";
                meshName = "Misc/Iron Ingot";
                type = ItemTypes.Misc;
                break;
            #endregion
            default:
                itemId = 0;
                name = "";
                description = "";
                amount = 0;
                value = 0;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "";
                meshName = "";
                type = ItemTypes.Misc;
                break;
        }

      
        Item temp = new Item
        {
            ID = itemId,
            Name = name,
            Description = description,
            Value = value,
            Amount = amount,
            Damage = damage,
            Amrour = armour,
            Heal = heal,
            IconName = Resources.Load("Icons/" + iconName) as Texture2D,
            MeshName = Resources.Load("Prefabs/" + meshName) as GameObject,
            ItemType = type
        };
        return temp;
    }


}
