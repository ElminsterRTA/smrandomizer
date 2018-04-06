using System;
using System.Collections.Generic;
using System.Linq;
using SuperMetroidRandomizer.Random;

namespace SuperMetroidRandomizer.Rom
{
    public class RomLocationsSpeedrunner : IRomLocations
    {
        public List<Location> Locations { get; set; }
        public string DifficultyName { get { return "Speedrunner"; } }
        public string SeedFileString { get { return "S{0:0000000}"; } }
        public string SeedRomString { get { return "SMRv{0} S{1}"; } }

        public void ResetLocations()
        {
            Locations = new List<Location>
                       {
                           new Location
                               {
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Power Bomb (Crateria surface)",
                                   Address = 0x781CC,
                                   CanAccess =
                                       have =>
                                       CanUsePowerBombs(have) 
                                       && (have.Contains(ItemType.SpeedBooster) 
                                           || have.Contains(ItemType.SpaceJump) 
                                           || CanIbj(have)),
                               },
                           new Location
                               { 
                                   GravityOkay = false,
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria depths bottom)",
                                   Address = 0x781E8,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have),
                               },
                           new Location
                               {     
                                   NoHidden = true,
                                   GravityOkay = false,                                   
                                   Region = Region.Crateria,
                                   Name = "Spring Ball",
                                   Address = 0x781EE,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {       
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria depths top)",
                                   Address = 0x781F4,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have),
                               },
                           new Location
                               {        
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria depths moat)",
                                   Address = 0x78248,
                                   CanAccess =
                                       have =>
                                       have.Contains(ItemType.SuperMissile) 
                                       && CanAccessEastMaridia(have),
                               },
                           new Location
                               {       
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria depths gauntlet)",
                                   Address = 0x78264,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                               },
                           new Location
                               {        
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria old MB)",
                                   Address = 0x783EE,
                                   CanAccess =
                                       have =>
                                       CanDestroyBombWalls(have)
									   && have.Contains(ItemType.MorphingBall),
                               },
                           new Location
                               {        
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Bomb",
                                   Address = 0x78404,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       have.Contains(ItemType.MorphingBall) &&
                                       CanOpenMissileDoors(have)
                               },
                           new Location
                               {     
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Energy Tank (Crateria tourminator)",
                                   Address = 0x78432,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have),
                               },
                           new Location
                               {       
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria gauntlet right)",
                                   Address = 0x78464,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                               },
                           new Location
                               {     
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria gauntlet left)",
                                   Address = 0x7846A,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                               },
                           new Location
                               {     
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria boyons)",
                                   Address = 0x78478,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have),
                               },
                           new Location
                               {       
                                   NoHidden = true,
                                   GravityOkay = false,     
                                   Region = Region.Crateria,
                                   Name = "Missile (Crateria dental plan)",
                                   Address = 0x78486,
                                   CanAccess =
                                       have =>
                                       CanPassBombPassages(have)
									   && CanOpenMissileDoors(have),
                               },
                           new Location
                               {        
                                   NoHidden = true,
                                   GravityOkay = false,
                                   Region = Region.Brinstar,
                                   Name = "Super Missile (Brinstar etecoons)",
                                   Address = 0x784AC,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have => 
                                       CanAccessBlueBrinstar(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {        
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar shinespark shaft)",
                                   Address = 0x784E4,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
									   && have.Contains(ItemType.WaveBeam),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false, 
                                   Region = Region.Brinstar,
                                   Name = "Missile (Speed Booster)",
                                   Address = 0x78518,
                                   CanAccess =
                                       have =>
                                       CanDestroyBombWalls(have) 
                                       && CanAccessGreenBrinstar(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Speed Booster",
                                   Address = 0x7851E,
                                   CanAccess =
                                       have =>
                                       CanDestroyBombWalls(have)
									   && CanAccessGreenBrinstar(have),
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Super Missile (Brinstar reserve)",
                                   Address = 0x7852C,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanPassSidehopperGate(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar construction zone)",
                                   Address = 0x7877E,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have),
                               },
                           new Location
                               {             
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar reserve)",
                                   Address = 0x78538,
                                   CanAccess =
                                       have =>
                                       CanPassSidehopperGate(have),
                               },
                           new Location
                               {             
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar big pink top)",
                                   Address = 0x78608,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar big pink bottom)",
                                   Address = 0x7860E,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have)
									   && CanDestroyBombWalls(have),
                               },
                           new Location
                               {             
                                   NoHidden = true,
                                   GravityOkay = false,      
                                   Region = Region.Brinstar,
                                   Name = "Charge Beam",
                                   Address = 0x78614,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,     
                                   Region = Region.Brinstar,
                                   Name = "Power Bomb (Brinstar mission impossible)",
                                   Address = 0x7865C,
                                   CanAccess =
                                       have =>
                                       CanUsePowerBombs(have) 
                                       && CanAccessGreenBrinstar(have),
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Hi-Jump Boots",
                                   Address = 0x78676,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have)
									   && (have.Contains(ItemType.HiJumpBoots)
									   || have.Contains(ItemType.SpaceJump)
									   || have.Contains(ItemType.SpeedBooster)
									   || CanIbj(have)),
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,              
                                   Region = Region.Brinstar,
                                   Name = "Morphing Ball",         
                                   Address = 0x786DE,
                                   CanAccess = 
                                       have => 
                                       true,
                               },
                           new Location
                               {              
                                   NoHidden = true,
                                   GravityOkay = false,      
                                   Region = Region.Brinstar,
                                   Name = "Power Bomb (blue Brinstar)",
                                   Address = 0x7874C,
                                   CanAccess =
                                       have => 
                                       CanAccessBlueBrinstar(have)
									   && CanPassBombPassages(have),
                               },
                           new Location
                               {              
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar blue middle)",
                                   Address = 0x78798,
                                   CanAccess =
                                       have =>
                                       have.Contains(ItemType.MorphingBall)
									   && (CanIbj(have)
									   || have.Contains(ItemType.SpeedBooster)
									   || (CanUsePowerBombs(have)
											&& (have.Contains(ItemType.HiJumpBoots)
											|| have.Contains(ItemType.SpaceJump)))),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Energy Tank (blue Brinstar)",
                                   Address = 0x7879E,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       have.Contains(ItemType.MorphingBall) 
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar beetoms)",
                                   Address = 0x787C2,
                                   CanAccess =
                                       have => 
                                       CanPassSidehopperGate(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Reserve Tank (Brinstar)",
                                   Address = 0x787D0,
                                   CanAccess =
                                       have =>
                                       CanPassSidehopperGate(have),
                               },
                           new Location
                               {          
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Energy Tank (Brinstar waterway)",
                                   Address = 0x787FA,
                                   CanAccess =
                                       have =>
                                       CanAccessBlueBrinstar(have)
									   && have.Contains(ItemType.SuperMissile)
									   && have.Contains(ItemType.GravitySuit)
									   && have.Contains(ItemType.SpeedBooster) 
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar first)",
                                   Address = 0x78802,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess = 
                                       have => 
                                       have.Contains(ItemType.MorphingBall),
                               },
                           new Location
                               {             
                                   NoHidden = true,
                                   GravityOkay = false,     
                                   Region = Region.Brinstar,
                                   Name = "Energy Tank (Speed Booster)",
                                   Address = 0x78824,
                                   CanAccess =
                                       have =>
                                       CanAccessGreenBrinstar(have),
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,    
                                   Region = Region.Brinstar,
                                   Name = "Missile (Brinstar Billy Mays)",
                                   Address = 0x78836,
                                   CanAccess =
                                       have =>
                                       CanAccessBlueBrinstar(have)
										&& CanOpenMissileDoors(have)
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,   
                                   Region = Region.Brinstar,
                                   Name = "Energy Tank (Brinstar Billy Mays)",
                                   Address = 0x7883C,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessBlueBrinstar(have)
										&& CanOpenMissileDoors(have)
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,      
                                   Region = Region.Brinstar,
                                   Name = "Super Missile (X-Ray Scope)",
                                   Address = 0x78876,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessRedBrinstar(have) 
                                       && CanUsePowerBombs(have),
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,            
                                   Region = Region.Maridia,
                                   Name = "Power Bomb (Maridia beta)",
                                   Address = 0x788CA,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
									   && have.Contains(ItemType.SuperMissile), 
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,        
                                   Region = Region.Brinstar,
                                   Name = "Power Bomb (Maridia alpha)",
                                   Address = 0x7890E,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have), 
                               },
                           new Location
                               {              
                                   NoHidden = true,
                                   GravityOkay = false,     
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Lower Norfair kihunters)",
                                   Address = 0x7902E,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have), 
                               },
                           new Location
                               {            
                                   GravityOkay = false, 
                                   Region = Region.Brinstar,
                                   Name = "Wave Beam",
                                   Address = 0x7896E,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessNorfair(have)
                               },
                           new Location
                               {           
                                   GravityOkay = false,
                                   Region = Region.Brinstar,
                                   Name = "Energy Tank (Kraid)",
                                   Address = 0x7899C,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessKraid(have),
                               },
                           new Location
                               {           
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Missile (Kraid)",
                                   Address = 0x789EC,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessKraid(have),
                               },
                           new Location
                               {            
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Gravity Suit",
                                   Address = 0x78ACA,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessKraid(have)
									   && (have.Contains(ItemType.SpeedBooster)
										|| have.Contains(ItemType.GrappleBeam)
										|| have.Contains(ItemType.SpaceJump)
										|| CanIbj(have)),
                               },
                           new Location
                               {              
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair cathedral)",
                                   Address = 0x78AE4,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessHeatedNorfair(have)
									   && have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {                    
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Ice Beam",
                                   Address = 0x78B24,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessHeatedNorfair(have)
                               },
                           new Location
                               {                  
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Ice Beam)",
                                   Address = 0x78B46,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessHeatedNorfair(have)
                               },
                           new Location
                               {                   
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Energy Tank (Crocomire)",
                                   Address = 0x78BA4,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have),
                               },
                           new Location
                               {                    
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Super Missile (Norfair first)",
                                   Address = 0x78BAC,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessNorfair(have), 
                               },
                           new Location
                               {                   
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair viola gate)",
                                   Address = 0x78BC0,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have)
                                       && have.Contains(ItemType.WaveBeam),
                               },
                           new Location
                               {                   
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Brinstar,
                                   Name = "Missile (post-Spore Spawn)",
                                   Address = 0x7895A,
                                   CanAccess =
                                       have =>
                                       CanAccessNorfair(have), 
                               },
                           new Location
                               {                    
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.Norfair,
                                   Name = "Energy Tank (Super Missile)",
                                   Address = 0x78BEC,
                                   CanAccess =
                                       have =>
                                       CanAccessNorfair(have), 
                               },
                           new Location
                               {                    
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Power Bomb (Crocomire)",
                                   Address = 0x78C04,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
                               },
                           new Location
                               {                    
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair acid tide)",
                                   Address = 0x78C14,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && (have.Contains(ItemType.GrappleBeam)
									   || have.Contains(ItemType.GravitySuit)),
                               },
                           new Location
                               {                   
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (post-Crocomire)",
                                   Address = 0x78C2A,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have),
                               },
                           new Location
                               {                     
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Power Bomb (Norfair first)",
                                   Address = 0x78C36,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have),
                               },
                           new Location
                               {                  
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Energy Tank (Norfair reserve)",
                                   Address = 0x78C3E,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have),
                               },
                           new Location
                               {                  
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair Reserve Tank)",
                                   Address = 0x78C44,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have)
                               },
                           new Location
                               {                 
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair pre-reserve)",
                                   Address = 0x78C52,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have),
                               },
                           new Location
                               {                       
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (pre-Crocomire)",
                                   Address = 0x78C66,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have), 
                               },
                           new Location
                               {                     
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Norfair speed hall)",
                                   Address = 0x78C74,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have), 
                               },
                           new Location
                               {                     
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Grappling Beam",
                                   Address = 0x78C82,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have), 
                               },
                           new Location
                               {                      
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Missile (Super Missile)",
                                   Address = 0x78CBC,
                                   CanAccess =
                                       have =>
                                       CanAccessNorfair(have)
									   && have.Contains(ItemType.SpeedBooster), 
                               },
                           new Location
                               {                     
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Norfair,
                                   Name = "Spazer",
                                   Address = 0x78CCA,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessCrocomire(have)
									   && CanUsePowerBombs(have)
                               },
                           new Location
                               {                     
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Gold Torizo)",
                                   Address = 0x78E6E,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                     
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Super Missile (Lower Norfair WRITG)",
                                   Address = 0x78F42,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                         
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Reserve Tank (Lower Norfair)",
                                   Address = 0x78F30,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have)
									   && have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Power Bomb (Lower Norfair metal pirates)",
                                   Address = 0x78FCA,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Lower Norfair top PB)",
                                   Address = 0x78FD2,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                         
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Missile (Lower Norfair wasteland)",
                                   Address = 0x790C0,
                                   CanAccess =
                                       have =>
                                       CanAccessLowerNorfair(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Energy Tank (Ridley)",
                                   Address = 0x79100,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have)
									   && have.Contains(ItemType.ChargeBeam)
									   && EnergyReserveCount(have) >= 2,
                               },
                           new Location
                               {                         
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Power Bomb (Lower Norfair WRITG)",
                                   Address = 0x79108,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                        
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Screw Attack",
                                   Address = 0x79110,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                        
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.LowerNorfair,
                                   Name = "Super Missile (Lower Norfair firefleas)",
                                   Address = 0x79184,
                                   CanAccess =
                                       have =>
                                       CanPassGoldStatue(have),
                               },
                           new Location
                               {                         
                                   NoHidden = true,
                                   GravityOkay = false,  
                                   Region = Region.WreckedShip,
                                   Name = "Missile (Wrecked Ship middle)",
                                   Address = 0x7C265,
                                   CanAccess =
                                       have =>
                                       CanAccessWs(have)
									   && have.Contains(ItemType.SpeedBooster)
									   && EnergyReserveCount(have) >= 1,
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Reserve Tank (Wrecked Ship)",
                                   Address = 0x7C2E9,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have)
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Missile (Varia Suit)",
                                   Address = 0x7C2EF,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have)
                                       && CanDestroyBombWalls(have)
                               },
                           new Location
                               {                          
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Missile (Wrecked Ship attic)",
                                   Address = 0x7C319,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have)
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Energy Tank (Wrecked Ship)",
                                   Address = 0x7C337,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Super Missile (Wrecked Ship left)",
                                   Address = 0x7C357,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have)
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Super Missile (Wrecked Ship right)",
                                   Address = 0x7C365,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have)
									   && CanPassBombPassages(have)
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.WreckedShip,
                                   Name = "Varia Suit",
                                   Address = 0x7C36D,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanDefeatPhantoon(have)
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia main street)",
                                   Address = 0x7C437,
                                   CanAccess =
                                       have =>
                                       CanAccessWestMaridia(have), 
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Energy Tank (Maridia main street)",
                                   Address = 0x7C43D,
                                   CanAccess =
                                       have =>
                                       CanAccessWestMaridia(have)
									   && CanUsePowerBombs(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Power Bomb (Maridia tatori)",
                                   Address = 0x7C47D,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Super Missile (Maridia tatori)",
                                   Address = 0x7C483,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Super Missile (Maridia watering hole)",
                                   Address = 0x7C4AF,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia watering hole)",
                                   Address = 0x7C4B5,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (post-Draygon)",
                                   Address = 0x7C533,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Plasma Beam",
                                   Address = 0x7C559,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Maridia reserve)",
                                   Address = 0x7C5DD,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Reserve Tank (Maridia)",
                                   Address = 0x7C5E3,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have),
                               },
                           new Location
                               {                           
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (Space Jump)",
                                   Address = 0x7C5EB,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Space Jump",
                                   Address = 0x7C5F1,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                                       && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (pre-Botwoon)",
                                   Address = 0x7C603,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                                       && have.Contains(ItemType.SuperMissile)
                                       && have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Super Missile (pre-Botwoon)",
                                   Address = 0x7C609,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                                       && have.Contains(ItemType.SuperMissile)
                                       && have.Contains(ItemType.SpeedBooster),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "X-Ray Scope",
                                   Address = 0x7C6E5,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
                                       && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Missile (pre-Draygon)",
                                   Address = 0x7C74D,
                                   ItemStorageType = ItemStorageType.Hidden,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have)
									   && have.Contains(ItemType.GrappleBeam)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                             
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Energy Tank (post-Botwoon)",
                                   Address = 0x7C755,
                                   CanAccess =
                                       have =>
                                       CanAccessEastMaridia(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                           new Location
                               {                            
                                   NoHidden = true,
                                   GravityOkay = true,  
                                   Region = Region.Maridia,
                                   Name = "Energy Tank (Draygon)",
                                   Address = 0x7C7A7,
                                   ItemStorageType = ItemStorageType.Chozo,
                                   CanAccess =
                                       have =>
                                       CanAccessDraygon(have)
									   && have.Contains(ItemType.SuperMissile),
                               },
                       };
        }

        private bool CanPassWorstRoomInTheGame(List<ItemType> have)
        {
            return CanAccessLowerNorfair(have)
                   && (have.Contains(ItemType.SpaceJump)
                       || have.Contains(ItemType.HiJumpBoots)
                       || have.Contains(ItemType.IceBeam)
                       || CanIbj(have));
        }

        private bool CanIbj(List<ItemType> have)
        {
            return (have.Contains(ItemType.Bomb)
                && have.Contains(ItemType.MorphingBall));
        }

        private bool CanDefeatDraygon(List<ItemType> have)
        {
            return CanDefeatBotwoon(have)
                && (have.Contains(ItemType.GravitySuit)
                    || ((have.Contains(ItemType.GrappleBeam)
                            || CanCrystalFlash(have))
                        && (have.Contains(ItemType.SpringBall)
                            || have.Contains(ItemType.XRayScope))));
        }

        private bool CanCrystalFlash(List<ItemType> have)
        {
            return have.Count(x => x == ItemType.Missile) >= 2
                && have.Count(x => x == ItemType.SuperMissile) >= 2 
                && have.Count(x => x == ItemType.PowerBomb) >= 3;
        }

        private bool CanDefeatBotwoon(List<ItemType> have)
        {
            return CanAccessInnerMaridia(have)
                && (have.Contains(ItemType.IceBeam) 
                    || have.Contains(ItemType.SpeedBooster));
        }

        private bool CanAccessInnerMaridia(List<ItemType> have)
        {
            return CanAccessRedBrinstar(have)
                && have.Contains(ItemType.PowerBomb)
                && (have.Contains(ItemType.GravitySuit)
                    || (have.Contains(ItemType.HiJumpBoots)
                        && have.Contains(ItemType.IceBeam)
                        && have.Contains(ItemType.GrappleBeam)));
        }

        private bool CanAccessOuterMaridia(List<ItemType> have)
        {
            return CanAccessRedBrinstar(have)
                && have.Contains(ItemType.PowerBomb)
                && (have.Contains(ItemType.GravitySuit) 
                    || (have.Contains(ItemType.HiJumpBoots)
                        && have.Contains(ItemType.IceBeam)));
        }
		
		private bool CanAccessWestMaridia(List<ItemType> have)
		{
			return CanAccessBlueBrinstar(have)
				&& have.Contains(ItemType.GravitySuit)
		}
		
		private bool CanAccessDraygon(List<ItemType> have)
		{
			return CanAccessWestMaridia(have)
				&& have.Contains(ItemType.SpeedBooster)
		}

        private bool CanAccessLowerNorfair(List<ItemType> have)
        {
            return CanAccessHeatedNorfair(have)
                && have.Contains(ItemType.PowerBomb)
                && have.Contains(ItemType.GravitySuit)
				&& have.Contains(ItemType.SuperMissile)
				&& (have.Contains(ItemType.SpaceJump)
				|| EnergyReserveCount(have) >= 3);
        }
		
		private bool CanPassGoldStatue(List<ItemType> have)
		{
			return CanAccessLowerNorfair(have)
			&& (have.Contains(ItemType.SpeedBooster)
			|| have.Contains(ItemType.SpaceJump))
		}

        private bool CanAccessCrocomire(List<ItemType> have)
        {
            return CanAccessNorfair(have)
                && (have.Contains(ItemType.VariaSuit)
				|| have.Contains(ItemType.GravitySuit));
        }

        private bool CanAccessHeatedNorfair(List<ItemType> have)
        {
            return CanAccessNorfair(have)
					&& (CanAccessGreenBrinstar(have)
					|| have.Contains(ItemType.VariaSuit) 
                    || have.Contains(ItemType.GravitySuit) 
                    || EnergyReserveCount(have) >= 3);
        }

        private static int EnergyReserveCount(List<ItemType> have)
        {
            var energyTankCount = have.Count(x => x == ItemType.EnergyTank);
            var reserveTankCount = Math.Min(have.Count(x => x == ItemType.ReserveTank), energyTankCount + 1);
            return energyTankCount + reserveTankCount;
        }

        private bool CanAccessKraid(List<ItemType> have)
        {
            return CanAccessNorfair(have)
                && CanUsePowerBombs(have);
        }

        private bool CanPassBombPassages(List<ItemType> have)
        {
            return (have.Contains(ItemType.Bomb) 
                    && have.Contains(ItemType.MorphingBall))
                || (have.Contains(ItemType.PowerBomb) 
                    && have.Contains(ItemType.MorphingBall));
        }

        private static bool CanUsePowerBombs(List<ItemType> have)
        {
            return have.Contains(ItemType.PowerBomb) 
                && have.Contains(ItemType.MorphingBall);
        }

        private static bool CanOpenMissileDoors(List<ItemType> have)
        {
            return have.Contains(ItemType.Missile) 
                || have.Contains(ItemType.SuperMissile);
        }

        private static bool CanDestroyBombWalls(List<ItemType> have)
        {
            return (have.Contains(ItemType.Bomb) 
                    && have.Contains(ItemType.MorphingBall))
                || (have.Contains(ItemType.PowerBomb) 
                    && have.Contains(ItemType.MorphingBall))
                || have.Contains(ItemType.ScrewAttack);
        }

        private static bool CanEnterAndLeaveGauntlet(List<ItemType> have)
        {
            return (have.Contains(ItemType.Bomb)
                    && have.Contains(ItemType.MorphingBall))
                || (have.Count(x => x == ItemType.PowerBomb) >= 2
                    && have.Contains(ItemType.MorphingBall))
                || have.Contains(ItemType.ScrewAttack);
        }

        private static bool CanDefeatPhantoon(List<ItemType> have)
        {
            return CanAccessWs(have)
				&& have.Contains(ItemType.SuperMissile);
        }
		
		private static bool CanAccessEastMaridia(List<ItemType> have)
		{	
			return have.Contains(ItemType.GravitySuit)
				&& have.Contains(ItemType.SpeedBooster)
				&& CanOpenMissileDoors(have)
				&& CanUsePowerBombs(have);
		}

        private static bool CanAccessWs(List<ItemType> have)
        {
            return CanAccessGreenBrinstar(have)
					|| (CanUsePowerBombs(have)
						&&	(have.Contains(ItemType.VariaSuit) 
							|| have.Contains(ItemType.GravitySuit) 
							|| EnergyReserveCount(have) >= 3));
        }
		
		private static bool CanAccessBlueBrinstar(List<ItemType> have)
		{	
			return (CanDestroyBombWalls(have)
				&& have.Contains(ItemType.MorphingBall)
				&& have.Contains(ItemType.SuperMissile))
				|| CanUsePowerBombs(have);
		}
		
		private static bool CanAccessRedBrinstar(List<ItemType> have)
		{
			return (CanOpenMissileDoors(have)
				&& CanPassBombPassages(have))
				|| (CanAccessBlueBrinstar(have)
				&& have.Contains(ItemType.SuperMissile));
		}
		
		private static bool CanAccessGreenBrinstar(List<ItemType> have)
		{
			return CanAccessRedBrinstar(have)
				&& have.Contains(ItemType.SuperMissile)
				&& have.Contains(ItemType.SpeedBooster);
		}
		
		private static bool CanPassSidehopperGate(List<ItemType> have)
		{
			return CanAccessGreenBrinstar(have)
				&& CanUsePowerBombs(have)
				&& have.Contains(ItemType.WaveBeam);
		}
		
		private static bool CanAccessNorfair(List<ItemType> have)
		{
			return CanAccessRedBrinstar(have)
				&& have.Contains(ItemType.SuperMissile)
		}

        public RomLocationsSpeedrunner()
        {
            ResetLocations();
        }

        public List<Location> GetAvailableLocations(List<ItemType> haveItems)
        {
            var retVal = (from Location location in Locations where (location.Item == null) && location.CanAccess(haveItems) select location).ToList();
            var currentWeight = (from item in retVal orderby item.Weight descending select item.Weight).First() + 1;

            foreach (var item in retVal.Where(item => item.Weight == 0))
            {
                item.Weight = currentWeight;
            }

            var addedItems = new List<List<Location>>();
            for (int i = 1; i < currentWeight; i++)
            {
                addedItems.Add(retVal.Where(x => x.Weight > i).ToList());
            }

            foreach (var list in addedItems)
            {
                retVal.AddRange(list);
            }

            return retVal;
        }

        public List<Location> GetUnavailableLocations(List<ItemType> haveItems)
        {
            return (from Location location in Locations where location.Item == null && !location.CanAccess(haveItems) select location).ToList();
        }

        public void TryInsertCandidateItem(List<Location> currentLocations, List<ItemType> candidateItemList, ItemType candidateItem)
        {
			// only try gravity if gravity is okay in this spot
			// only insert multiples of an item into the candidate list if we aren't looking at the morph ball slot.
			if (!(candidateItem == ItemType.GravitySuit && !currentLocations.Any(x => x.GravityOkay)) && (currentLocations.All(x => x.Name != "Morphing Ball") || !candidateItemList.Contains(candidateItem)))
            {
                candidateItemList.Add(candidateItem);
            }
        }

        public int GetInsertedLocation(List<Location> currentLocations, ItemType insertedItem, SeedRandom random)
        {
            int retVal;

            do
            {
                retVal = random.Next(currentLocations.Count);
            } while (insertedItem == ItemType.GravitySuit && !currentLocations[retVal].GravityOkay);

            return retVal;
        }

        public ItemType GetInsertedItem(List<Location> currentLocations, List<ItemType> itemPool, SeedRandom random)
        {
            ItemType retVal;

            do
            {
                retVal = itemPool[random.Next(itemPool.Count)];
            } while (retVal == ItemType.GravitySuit && !currentLocations.Any(x => x.GravityOkay));

            return retVal;
        }

        public List<ItemType> GetItemPool(SeedRandom random)
        {
            return new List<ItemType>
                       {
                           ItemType.MorphingBall,
                           ItemType.Bomb,
                           ItemType.ChargeBeam,
                           ItemType.ChargeBeam,
                           ItemType.ChargeBeam,
                           ItemType.ChargeBeam,
                           ItemType.Spazer,
                           ItemType.VariaSuit,
                           ItemType.HiJumpBoots,
                           ItemType.SpeedBooster,
                           ItemType.WaveBeam,
                           ItemType.GrappleBeam,
                           ItemType.GravitySuit,
                           ItemType.SpaceJump,
                           ItemType.SpringBall,
                           ItemType.PlasmaBeam,
                           ItemType.IceBeam,
                           ItemType.ScrewAttack,
                           ItemType.XRayScope,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.ReserveTank,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.Missile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.SuperMissile,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.PowerBomb,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                           ItemType.EnergyTank,
                       };
        }
    }
}
