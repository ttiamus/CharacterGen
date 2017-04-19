using System.Collections.Generic;
using CharacterGen.Domain.AbilityScore;
using CharacterGen.Domain.Background;
using CharacterGen.Domain.Class;
using CharacterGen.Domain.Currencies;
using CharacterGen.Domain.Demographic;
using CharacterGen.Domain.Enums;
using CharacterGen.Domain.Equipment.AdventuringGear;
using CharacterGen.Domain.Equipment.Armor;
using CharacterGen.Domain.Equipment.Tool;
using CharacterGen.Domain.Equipment.Weapon;
using CharacterGen.Domain.Equipment.WonderousItem;
using CharacterGen.Domain.Feat;
using CharacterGen.Domain.Languages;
using CharacterGen.Domain.Race;
using CharacterGen.Domain.Roleplay;
using CharacterGen.Domain.SavingThrow;
using CharacterGen.Domain.Skill;
using MongoDB.Bson;

namespace CharacterGen.Domain.Character
{
    public class Character : ICharacter
    {
        //TODO: Consider unflattening ability scores, demographics, and currency
        //TODO: Decide how to handle proficiencies. Do I need a IsSelected or return what's on the character and a master list

        public IAbilityScores AbilityScores { get; set; }
        
        public IDemographic Demographic { get; set; }
        public Alignment Alignment {get;set;}

        public int ProficiencyBonus { get; set; }
        public int Inititive { get; set; }
        public int ArmorClass { get; set; }
        public int HitPoints { get; set; }
        public IEnumerable<HitDie> HitDice { get; set; } //could be multiple
        public int MovementSpeed { get; set; }

        public int PassivePerception { get; set; }

        public int CurrentCarryWeight { get; set; }
        public int MaxCarryWeight { get; set; }

        public ICurrency Currency{get;set;}

        public IRoleplay Roleplay { get; set; }

        public IRace Race {get;set;}
        public IBackground Background {get;set;}
        public IEnumerable<IClass> Classes {get;set;}
        public IEnumerable<ISkill> Skills {get;set;}
        public IEnumerable<ISavingThrow> SavingThrows {get;set;}
        public IEnumerable<IFeat> Feats {get;set;}

        public IEnumerable<ILanguage> Languages {get;set;}
        public IEnumerable<IWeapon> WeaponProficiencies {get;set;}
        public IEnumerable<IArmor> ArmorProficiencies {get;set;}
        public IEnumerable<ITool> ToolProficiencies {get;set;}


        public IEnumerable<IAdventuringGear> AdventuringGear {get;set;}
        public IEnumerable<IArmor> Armor {get;set;}
        public IEnumerable<IWeapon> Weapons {get;set;}
        public IEnumerable<ITool> Tools {get;set;}
        public IEnumerable<IWonderousItem> WonderousItems {get;set;}
    }
}