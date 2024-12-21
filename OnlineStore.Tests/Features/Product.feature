Feature: Operacje na produktach
  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

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

Scenario: Usunięcie produktu "Product 1"
    Given produkt "Product 1" istnieje w bazie danych
    And użytkownik otwiera stronę "Products"
    When użytkownik klika przycisk "Delete" dla pierwszego elementu
    And użytkownik potwierdza usunięcie
    Then w bazie danych nie powinna być produkt "Product 1"
    And użytkownik powinien zobaczyć stronę "Products"