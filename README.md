# 01-02-01-MazeProject
## LabirintusProjekt (MazeProject)
Egy játék kifejlesztésében vesz részt. A játék célja a játékosnak a labirintusból való kijutása. 
Ön a kódfejlesztés során a játékos kezelését, mozgását fogja implementálni. 
Fejlessze ki ennek megfelelően a Player osztályt.


Minden játékosnak ismert a neve és a kétdimenziós játéktéren az x és y koordinátája. 
A fejlesztő csapat megegyezése alapján, a játékost nevével és két koordinátájának megadásával lehet létrehozni. Készítse el az osztály konstruktorát!
A játékos mozoghat északra, délre, nyugatra, keletre. Ilyenkor a megfelelő koordinátája változik! A felfelé mozgás felel meg az északi iránynak! A metódusok neveit a mozgás és irány angol szavakból képezze!


A mozgás ellenőrzéseként írnia kell egy metódus, amely kiírja a játékos nevét és koordinátáját. A metódus neve legyen „ToConsole”.
Pl. ha a játékos neve „Játékos Jani”, és a (2,3) koordinátán tartózkodik akkor a kiírást egy új sorral záruljon és a következő formátumba jelenjen meg:
Játékos Jani:(2;0)


A fejlesztés során Önnek nem kell foglalkoznia avval, hogy a játékos neki megy-e a labirintus falának vagy nem.
Ellenőrzésként vegye fel „Játékos Jani” játékost, aki a (2,1) koordinátán tartózkodik, és „Elveszett Eszter” játékost, aki a (-1,2) koordinátán tartózkodik. Írja ki a helyzetüket! Mozgassa Játékos Janit-t Elveszett Eszter pozíciójába! Minden lépés után jelenítse meg helyzetét!

