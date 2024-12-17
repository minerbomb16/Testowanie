Feature: Nawigacja między stronami
  Jako użytkownik aplikacji
  Chcę móc przechodzić między stronami
  Aby uzyskać dostęp do różnych części aplikacji

  Scenario: Przejście na stronę kategorii
    Given użytkownik otwiera stronę "Categories"
    Then użytkownik powinien zobaczyć stronę "Categories"

  Scenario: Przejście na stronę produktów
    Given użytkownik otwiera stronę "Products"
    Then użytkownik powinien zobaczyć stronę "Products"

  Scenario: Przejście na stronę zamówień
    Given użytkownik otwiera stronę "Orders"
    Then użytkownik powinien zobaczyć stronę "Orders"

  Scenario: Przejście z kategorii na stronę główną
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Home"
    Then użytkownik powinien zobaczyć stronę "Home"