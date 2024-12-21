Feature: Operacje na kategoriach
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

Scenario: Usunięcie kategorii "Category 1"
    Given kategoria "Category 1" istnieje w bazie danych
    And użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Delete" dla pierwszego elementu
    And użytkownik potwierdza usunięcie
    Then w bazie danych nie powinna być kategoria "Category 1"
    And użytkownik powinien zobaczyć stronę "Categories"