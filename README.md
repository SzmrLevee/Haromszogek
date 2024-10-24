# Pontok kiválasztásának logikája:
Rendezés Y koordináta szerint:

A program először rendezi a pontokat az Y koordinátáik alapján. Az a pont, amelyiknek a legkisebb az Y értéke (azaz a legalsó helyen van a koordináta-rendszerben), az lesz az A pont.
Ha két pontnak azonos az Y értéke, akkor az X koordináta alapján rendezi őket, vagyis azt a pontot választja, amelyik a legbaloldalibb (legkisebb X értékkel rendelkezik).
Ezzel garantáljuk, hogy az A pont mindig a legalsó és egyben legbaloldalibb pont lesz.
Óramutató járásával ellentétes sorrend:

Miután kiválasztottuk az A pontot, a maradék két pontot (most már csak B és C) az alapján rendezzük, hogy hogyan helyezkednek el az A ponthoz képest.
Kiszámoljuk a két megmaradt pont dőlésszögét az A ponthoz viszonyítva. Az a pont, amelyiknek kisebb a dőlésszöge az A-hoz képest, az lesz a B pont, a másik pedig a C pont.
Ez biztosítja, hogy a pontok elrendezése mindig az óramutató járásával ellentétes irányban történjen.
Példa:
Tegyük fel, hogy a következő koordinátákat adtuk meg:

A: (-3, -3)

B: (3, -3)

C: (0, 3)

Először a program megnézi az Y koordinátákat. Mivel mind az A, mind a B pontoknak azonos az Y értéke (-3), az X koordináta alapján rendezi őket. Az A pont X értéke kisebb, tehát az A marad az A pont.

A maradék két pont közül az A-hoz képest kiszámoljuk a dőlésszöget. A B pont dőlésszöge kisebb lesz, így a B pont megmarad B-nek, a C pont pedig C lesz.

Összefoglalás:
Az A pont mindig a legalsó pont lesz, és ha több pontnak is ugyanaz az Y értéke van, akkor a baloldalibb pont lesz az A.
A maradék két pontot az A ponthoz viszonyított dőlésszög alapján rendezzük, hogy az óramutató járásával ellentétes sorrendet kapjunk.

Projekt letöltésének linkje:
https://drive.google.com/drive/folders/183nDddAUoYV9_7KKX5IWdcDQO4We3B4T?usp=sharing
