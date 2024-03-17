# Battle Royale

Cvièení na dìdiènost a polymorfismus v objektovém programování v jazyce C#.

Originál zadání: [Školní sharepoint](https://pslib.sharepoint.com/sites/studium/prg/SitePages/CSharp-Ex-BattleRoyale.aspx)

Rozhodli jsme se vytvoøit vlastní hru. Bude to battle royale z fantasy prostøedí. Než se ale pustíme do vytváøení grafiky, vizuálních efektù a animací (což reálnì dìlat nebudeme) bylo by asi vhodné otestovat si, zda je navržený bojový systém vybalancovaný.

Prvním úkolem tedy bude vytvoøit konzolovou aplikaci, která celou hru odehraje za nás. Pokud na konci hry zùstane vždy stejná herní tøída, tak je model špatný a bude potøeba ho rebalancovat.

## Herní tøídy
V následujícím textu považujeme za živého takového bojovníka, který má kladnou nenulovou bilanci HP (Hit Points). Tedy i kostlivec mùže být živý. Jen živý bojovník mùže na ostatní útoèit.

Dále pøedpokládáme, že všichni bojovníci jsou reprezentování objekty uloženými v poli (combatants) nejzákladnìjšího typu.

### Enemy
Základní herní tøída obsahuje jen základní poèet HP. Umí si vybrat náhodného živého soupeøe (PickOpponent) a na nìj zaútoèit (Attack), mùže také získat poškozeni (ReceiveDamage). Je schopná poskytovat informaci o aktuálním poètu HP (HP), maximálním poètu HP (MaxHP) a zda je naživu (IsAlive). Pøes metodu ToString() je schopná tyto informaci zobrazit na konzoli testovacího programu.

### Fighter
Klasický lidský bojovník vyzbrojený zbraní. Rozšiøuje základní tøídu Enemy o své jméno (Name), které se objeví ve výpisu pøes ToString(). Také má o nìco lepší než základní útok.

### Knight
Rytíø je v podstatì vylepšený Fighter. Disponuje brnìním, které snižuje o nìkolik bodù jakékoli obdržené zranìní. Na druhou stranu nemá tak vysoký útok.

### Sorcerer
Èarodìj má proti základnímu bojovníkovi k dispozici magii. Dokud bude mít manu, budou jeho útoky extrémnì silné. Jakmile ale bude bez many, budou doslova ubohé. Aktuální stav many by se mìl objevit ve výpisu oponentù.

### Beast
Beast je anonymní nepøítel obdaøený schopností pøi útoku svého protivníka paralyzovat (Paralyze). Takový oponent nebude v tomto kole schopný útoèit. Jakou tøídu bude potøeba upravit o vlastnost IsParalyzed a o metodu pro zrušení paralýzy (RemoveParalyzed)?

## Prùbìh simulace
Hlavní cyklus simulace (jestli bude v nìjaké tøídì nebo jen v Program.cs je vlastnì nepodstatné) postupnì vyvolává objekty z pole combatants a - pokud jsou živí - nechá je vybrat soupeøe a zaútoèit. Každý útok vypíše informaci kdo zaútoèil na koho a jak silnì. Po skonèení herního kola se vypíše stav všech bojovníkù a zkontroluje, jestli ještì má kdo bojovat.

Metoda pro výbìr oponenta PickOpponent funguje tak, že objekt má k dispozici referencí pøedané pole všech bojovníkù a z nich vybírá náhodnou hodnotu tak dlouho, dokud nenatrefí na nìkoho živého. 

## Vylepšení
* Iniciativa bojovníkù
* Tøída Berserker, která si pamatuje na koho útoèila a bude na nìj útoèit znovu.
* Tøída Assassin, který udìluje sice malé zranìní, ale to se pak projevuje po urèený poèet herních kol.
* Mùže postava útoèit sama na sebe?
* ???