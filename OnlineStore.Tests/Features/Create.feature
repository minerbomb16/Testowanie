Feature: Tworzenie nowej kategorii
  Jako użytkownik
  Chcę móc utworzyć nową kategorię
  Aby poszerzyć katalog produktów

  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

  Scenario: Utworzenie kategorii
    Given w bazie danych nie ma kategorii "<Name>"
    And użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Create New"
    And użytkownik wpisuje w polu "Name" wartość "<Name>"
    And użytkownik klika przycisk "Create"
    Then w bazie danych powinna być kategoria "<Name>"
    And użytkownik powinien zobaczyć stronę "Categories"

    Examples: 
    | Name       |
    | Category 4 |
    | ąść        |
    | !@#$%^&*() |

Scenario: Walidacja tworzenia kategorii z nieprawidłowymi danymi
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Create New"
    And użytkownik wpisuje w polu "Name" wartość "<Name>"
    And użytkownik klika przycisk "Create"
    Then użytkownik powinien zobaczyć komunikat o błędzie "<ErrorMessage>"
    And użytkownik powinien zobaczyć stronę "Categories/Create"

    Examples: 
    | Name                                                                  | ErrorMessage                |
    |                                                                       | The Name field is required. |
    | aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa | Name too long.              |

Scenario: Utworzenie produktu
  Given w bazie danych nie ma produktu "<Name>"
  And użytkownik otwiera stronę "Products"
  When użytkownik klika przycisk "Create New"
  And użytkownik wpisuje w polu "Name" wartość "<Name>"
  And użytkownik wpisuje w polu "Price" wartość "<Price>"
  And użytkownik wpisuje w polu "CategoryId" wartość "<CategoryId>"
  And użytkownik wpisuje w polu "Description" wartość "<Description>"
  And użytkownik wpisuje w polu "Specifications" wartość "<Specifications>"
  And użytkownik klika przycisk "Create"
  Then w bazie danych powinien być produkt "<Name>"
  And użytkownik powinien zobaczyć stronę "Products"

  Examples:
    | Name        | Price | CategoryId | Description     | Specifications        |
    | Sausage     | 7     | 1          | very tasty      | makes you less hungry |
    | TV          | 5000  | 2          | very expensive  | makes you even dumber |
    | Nigger      | 2137  | 3          | very black      | works for free        |

Scenario: Walidacja tworzenia produktu z nieprawidłowymi danymi
  Given użytkownik otwiera stronę "Products"
  When użytkownik klika przycisk "Create New"
  And użytkownik wpisuje w polu "Name" wartość "<Name>"
  And użytkownik wpisuje w polu "Price" wartość "<Price>"
  And użytkownik wpisuje w polu "CategoryId" wartość "<CategoryId>"
  And użytkownik wpisuje w polu "Description" wartość "<Description>"
  And użytkownik wpisuje w polu "Specifications" wartość "<Specifications>"
  And użytkownik klika przycisk "Create"
  Then użytkownik powinien zobaczyć komunikat o błędzie "<ErrorMessage>"
  And użytkownik powinien zobaczyć stronę "Products/Create"

  Examples:
    | Name        | Price | CategoryId | Description       | Specifications          | ErrorMessage                     |
    |             | 1     | 1          | Opis produktu 1   | Specyfikacja produktu 1 | Name is required.                |
    | Product 2   | -1    | 2          | Opis produktu 2   | Specyfikacja produktu 2 | Price must be greater than zero. |
    | Product 3   | 1     | 3          |                   | Specyfikacja produktu 3 | Description is required.         |
    | Product 4   | 1     | 1          | Opis produktu 4   |                         | Specifications are required.     |

Scenario: Utworzenie zamówienia
  Given w bazie danych nie ma zamówienia dla "<CustomerName>"
  And użytkownik otwiera stronę "Orders"
  When użytkownik klika przycisk "Create New"
  And użytkownik wpisuje w polu "CustomerName" wartość "<CustomerName>"
  And użytkownik wpisuje w polu "OrderDate" wartość "<OrderDate>"
  And użytkownik wpisuje w polu "productIds" wartość "<productIds>"
  And użytkownik wpisuje w polu "quantities" wartość "<quantities>"
  And użytkownik klika przycisk "Create"
  Then w bazie danych powinno być zamówienie dla "<CustomerName>"
  And użytkownik powinien zobaczyć stronę "Orders"

  Examples:
    | CustomerName | OrderDate  | productIds | quantities |
    | Paweł        | 01.02.2003 | 1          | 3          |
    | Czesio       | 05.07.2004 | 2          | 4          |
    | Stodolski    | 12.11.2001 | 3          | 5          |

Scenario: Walidacja utworzenia zamówienia z nieprawidłowymi danymi
  Given w bazie danych nie ma zamówienia dla "<CustomerName>"
  And użytkownik otwiera stronę "Orders"
  When użytkownik klika przycisk "Create New"
  And użytkownik wpisuje w polu "CustomerName" wartość "<CustomerName>"
  And użytkownik wpisuje w polu "OrderDate" wartość "<OrderDate>"
  And użytkownik wpisuje w polu "productIds" wartość "<productIds>"
  And użytkownik wpisuje w polu "quantities" wartość "<quantities>"
  And użytkownik klika przycisk "Create"
  Then użytkownik powinien zobaczyć komunikat o błędzie "<ErrorMessage>"
  And użytkownik powinien zobaczyć stronę "Orders/Create"

  Examples:
    | CustomerName | OrderDate  | productIds           | quantities | ErrorMessage                                                 |
    |              | 01.02.2003 | 1                    | 3          | The CustomerName field is required.                          |
    | Paweł        |            | 2                    | 4          | The value &#x27;&#x27; is invalid.                           |
    | Czesio       | 04.mm.rrrr | 2                    | 4          | The value &#x27;04.mm.rrrr&#x27; is not valid for OrderDate. |
    | Stodolski    | 12.11.2001 | -- Select Product -- | 5          |                                                              |
    | Maciuś       | 12.11.2001 | 1                    | 0          |                                                              |

