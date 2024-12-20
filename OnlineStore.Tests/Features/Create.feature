Feature: Tworzenie nowej kategorii
  Jako użytkownik
  Chcę móc utworzyć nową kategorię
  Aby poszerzyć katalog produktów

  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

  Scenario: Utworzenie kategorii "Category 4"
    Given w bazie danych nie ma kategorii "Category 4"
    And użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Create New"
    And użytkownik wpisuje w polu "Name" wartość "Category 4"
    And użytkownik klika przycisk "Create"
    Then w bazie danych powinna być kategoria "Category 4"

Scenario Outline: Utworzenie produktu
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

  Examples:
    | Name        | Price | CategoryId | Description     | Specifications        |
    | Sausage     | 7     | 1          | very tasty      | makes you less hungry |
    | TV          | 5000  | 2          | very expensive  | makes you even dumber |
    | Nigger      | 2137  | 3          | very black      | works for free        |

Scenario Outline: Walidacja tworzenia produktu z nieprawidłowymi danymi
  Given użytkownik otwiera stronę "Products"
  When użytkownik klika przycisk "Create New"
  And użytkownik wpisuje w polu "Name" wartość "<Name>"
  And użytkownik wpisuje w polu "Price" wartość "<Price>"
  And użytkownik wpisuje w polu "CategoryId" wartość "<CategoryId>"
  And użytkownik wpisuje w polu "Description" wartość "<Description>"
  And użytkownik wpisuje w polu "Specifications" wartość "<Specifications>"
  And użytkownik klika przycisk "Create"
  Then użytkownik powinien zobaczyć komunikat o błędzie "<ErrorMessage>"

  Examples:
    | Name        | Price | CategoryId | Description       | Specifications          | ErrorMessage                     |
    |             | 1     | 1          | Opis produktu 1   | Specyfikacja produktu 1 | Name is required.                |
    | Product 2   | -1    | 2          | Opis produktu 2   | Specyfikacja produktu 2 | Price must be greater than zero. |
    | Product 3   | 1     | 3          |                   | Specyfikacja produktu 3 | Description is required.         |
    | Product 4   | 1     | 1          | Opis produktu 4   | Specyfikacja produktu 4 | Specifications are required.     |

