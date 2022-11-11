1. Użytyty framework - [**Playwright**]("https://playwright.dev/dotnet/docs/intro") 


#Scenariusze
Dodanie produktu do koszyka na stronie "https://sklep.kfd.pl/" i sprawdzenie czy faktycznie jest tam widoczny po dodaniu go
1. Idziemy na stronę https://sklep.kfd.pl/
2. Asercja, czy koszyk jest w ogóle widoczny
3. Wpisujemy w wyszukiwarke nazwę produktu, w naszym przypadku "whey gold"
4. Klikamy przycisk szukania
5. Wchodzimy w konkretny produkt z wyników wyszukiwania, w naszym przypadku pierwszy od lewej
6. Dodajemy go do koszyka
7. Po dodaniu do koszyka wyskakuje popup gdzie klikamy przycisk "Idź do kasy"
8. Po przeniesieniu do koszyka asercja czy nasz produkt jest tam faktycznie widoczny