Feature: Operacje na zamówieniach
  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

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

Scenario: Usunięcie zamówienia dla "Customer 1"
    Given zamówienie dla "Customer 1" istnieje w bazie danych
    And użytkownik otwiera stronę "Orders"
    When użytkownik klika przycisk "Delete" dla pierwszego elementu
    And użytkownik potwierdza usunięcie
    Then w bazie danych nie powinna być zamówienie dla "Customer 1"
    And użytkownik powinien zobaczyć stronę "Orders"