# Battle Royale

Cvi�en� na d�di�nost a polymorfismus v objektov�m programov�n� v jazyce C#.

Origin�l zad�n�: [�koln� sharepoint](https://pslib.sharepoint.com/sites/studium/prg/SitePages/CSharp-Ex-BattleRoyale.aspx)

Rozhodli jsme se vytvo�it vlastn� hru. Bude to battle royale z fantasy prost�ed�. Ne� se ale pust�me do vytv��en� grafiky, vizu�ln�ch efekt� a animac� (co� re�ln� d�lat nebudeme) bylo by asi vhodn� otestovat si, zda je navr�en� bojov� syst�m vybalancovan�.

Prvn�m �kolem tedy bude vytvo�it konzolovou aplikaci, kter� celou hru odehraje za n�s. Pokud na konci hry z�stane v�dy stejn� hern� t��da, tak je model �patn� a bude pot�eba ho rebalancovat.

## Hern� t��dy
V n�sleduj�c�m textu pova�ujeme za �iv�ho takov�ho bojovn�ka, kter� m� kladnou nenulovou bilanci HP (Hit Points). Tedy i kostlivec m��e b�t �iv�. Jen �iv� bojovn�k m��e na ostatn� �to�it.

D�le p�edpokl�d�me, �e v�ichni bojovn�ci jsou reprezentov�n� objekty ulo�en�mi v poli (combatants) nejz�kladn�j��ho typu.

### Enemy
Z�kladn� hern� t��da obsahuje jen z�kladn� po�et HP. Um� si vybrat n�hodn�ho �iv�ho soupe�e (PickOpponent) a na n�j za�to�it (Attack), m��e tak� z�skat po�kozeni (ReceiveDamage). Je schopn� poskytovat informaci o aktu�ln�m po�tu HP (HP), maxim�ln�m po�tu HP (MaxHP) a zda je na�ivu (IsAlive). P�es metodu ToString() je schopn� tyto informaci zobrazit na konzoli testovac�ho programu.

### Fighter
Klasick� lidsk� bojovn�k vyzbrojen� zbran�. Roz�i�uje z�kladn� t��du Enemy o sv� jm�no (Name), kter� se objev� ve v�pisu p�es ToString(). Tak� m� o n�co lep�� ne� z�kladn� �tok.

### Knight
Ryt�� je v podstat� vylep�en� Fighter. Disponuje brn�n�m, kter� sni�uje o n�kolik bod� jak�koli obdr�en� zran�n�. Na druhou stranu nem� tak vysok� �tok.

### Sorcerer
�arod�j m� proti z�kladn�mu bojovn�kovi k dispozici magii. Dokud bude m�t manu, budou jeho �toky extr�mn� siln�. Jakmile ale bude bez many, budou doslova uboh�. Aktu�ln� stav many by se m�l objevit ve v�pisu oponent�.

### Beast
Beast je anonymn� nep��tel obda�en� schopnost� p�i �toku sv�ho protivn�ka paralyzovat (Paralyze). Takov� oponent nebude v tomto kole schopn� �to�it. Jakou t��du bude pot�eba upravit o vlastnost IsParalyzed a o metodu pro zru�en� paral�zy (RemoveParalyzed)?

## Pr�b�h simulace
Hlavn� cyklus simulace (jestli bude v n�jak� t��d� nebo jen v Program.cs je vlastn� nepodstatn�) postupn� vyvol�v� objekty z pole combatants a - pokud jsou �iv� - nech� je vybrat soupe�e a za�to�it. Ka�d� �tok vyp�e informaci kdo za�to�il na koho a jak siln�. Po skon�en� hern�ho kola se vyp�e stav v�ech bojovn�k� a zkontroluje, jestli je�t� m� kdo bojovat.

Metoda pro v�b�r oponenta PickOpponent funguje tak, �e objekt m� k dispozici referenc� p�edan� pole v�ech bojovn�k� a z nich vyb�r� n�hodnou hodnotu tak dlouho, dokud nenatref� na n�koho �iv�ho. 

## Vylep�en�
* Iniciativa bojovn�k�
* T��da Berserker, kter� si pamatuje na koho �to�ila a bude na n�j �to�it znovu.
* T��da Assassin, kter� ud�luje sice mal� zran�n�, ale to se pak projevuje po ur�en� po�et hern�ch kol.
* M��e postava �to�it sama na sebe?
* ???