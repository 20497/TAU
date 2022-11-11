1. Użytyty framework - [**Playwright**]("https://playwright.dev/dotnet/docs/intro") 


# Scenariusze

## Dodanie produktu do koszyka na stronie "https://sklep.kfd.pl/" i sprawdzenie czy faktycznie jest tam widoczny po dodaniu go
1. Idziemy na stronę https://sklep.kfd.pl/
2. Asercja, czy koszyk jest w ogóle widoczny
3. Wpisujemy w wyszukiwarke nazwę produktu, w naszym przypadku "whey gold"
4. Klikamy przycisk szukania
5. Wchodzimy w konkretny produkt z wyników wyszukiwania, w naszym przypadku pierwszy od lewej
6. Dodajemy go do koszyka
7. Po dodaniu do koszyka wyskakuje popup gdzie klikamy przycisk "Idź do kasy"
8. Po przeniesieniu do koszyka asercja czy nasz produkt jest tam faktycznie widoczny

## Wyfiltrowanie przepisu na pierogi z kaczką na stronie "https://kuchnialidla.pl/" i sprawdzenie czy faktycznie znajdziemy takowy przepis oraz czy po kliknięciu w niego pokazuje się strona z przepisem
1. Idziemy na stronę https://kuchnialidla.pl/
2. Akceptujemy popup z plikami cookies
3. Wpisujemy w wyszukiwarkę nazwę przepisu, w naszym przypadku "pierogi z kaczka"
4. Klikamy przycisk szukania
5. Wchodzimy w konkretny przepis, w naszym przypadku jest tylko jeden do wyboru dla "pierogi z kaczka"
6. Sprawdzamy asercją czy strona przepisu się wyświetliła sprawdzając czy istnieje header o nazwie "PIEROGI Z KACZKĄ"