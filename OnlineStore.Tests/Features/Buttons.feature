Feature: Testowanie przycisków Edit, Details i Delete na stronie kategorii oraz produktów
  Jako użytkownik aplikacji
  Chcę móc używać przycisków Edit, Details i Delete
  Aby uzyskać dostęp do odpowiednich podstron dla kategorii, produktów i zamówień

  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

  Scenario: Przycisk Edit dla pierwszej kategorii
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Edit" dla pierwszej kategorii
    Then użytkownik powinien zostać przeniesiony na stronę "/categories/edit/1"

  Scenario: Przycisk Details dla pierwszej kategorii
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Details" dla pierwszej kategorii
    Then użytkownik powinien zostać przeniesiony na stronę "/categories/details/1"

  Scenario: Przycisk Delete dla pierwszej kategorii
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Delete" dla pierwszej kategorii
    Then użytkownik powinien zostać przeniesiony na stronę "/categories/delete/1"

  Scenario: Przycisk Edit dla pierwszego produktu
    Given użytkownik otwiera stronę "Products"
    When użytkownik klika przycisk "Edit" dla pierwszego produktu
    Then użytkownik powinien zostać przeniesiony na stronę "/products/edit/1"

  Scenario: Przycisk Details dla pierwszego produktu
    Given użytkownik otwiera stronę "Products"
    When użytkownik klika przycisk "Details" dla pierwszego produktu
    Then użytkownik powinien zostać przeniesiony na stronę "/products/details/1"

  Scenario: Przycisk Delete dla pierwszego produktu
    Given użytkownik otwiera stronę "Products"
    When użytkownik klika przycisk "Delete" dla pierwszego produktu
    Then użytkownik powinien zostać przeniesiony na stronę "/products/delete/1"

  Scenario: Przycisk Edit dla pierwszego zamówienia
    Given użytkownik otwiera stronę "Orders"
    When użytkownik klika przycisk "Edit" dla pierwszego zamówienia
    Then użytkownik powinien zostać przeniesiony na stronę "/orders/edit/1"

  Scenario: Przycisk Details dla pierwszego zamówienia
    Given użytkownik otwiera stronę "Orders"
    When użytkownik klika przycisk "Details" dla pierwszego zamówienia
    Then użytkownik powinien zostać przeniesiony na stronę "/orders/details/1"

  Scenario: Przycisk Delete dla pierwszego zamówienia
    Given użytkownik otwiera stronę "Orders"
    When użytkownik klika przycisk "Delete" dla pierwszego zamówienia
    Then użytkownik powinien zostać przeniesiony na stronę "/orders/delete/1"