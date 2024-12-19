Feature: Testowanie przycisków Edit, Details i Delete
  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

  @categories
  Scenario Outline: Przycisk <Button> dla pierwszej kategorii
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "<Button>" dla pierwszej kategorii
    Then użytkownik powinien zostać przeniesiony na stronę "/categories/<urlSuffix>/1"

    Examples:
      | Button   | urlSuffix |
      | Edit     | edit      |
      | Details  | details   |
      | Delete   | delete    |

  @products
  Scenario Outline: Przycisk <Button> dla pierwszego produktu
    Given użytkownik otwiera stronę "Products"
    When użytkownik klika przycisk "<Button>" dla pierwszego produktu
    Then użytkownik powinien zostać przeniesiony na stronę "/products/<urlSuffix>/1"

    Examples:
      | Button   | urlSuffix |
      | Edit     | edit      |
      | Details  | details   |
      | Delete   | delete    |

  @orders
  Scenario Outline: Przycisk <Button> dla pierwszego zamówienia
    Given użytkownik otwiera stronę "Orders"
    When użytkownik klika przycisk "<Button>" dla pierwszego zamówienia
    Then użytkownik powinien zostać przeniesiony na stronę "/orders/<urlSuffix>/1"

    Examples:
      | Button   | urlSuffix |
      | Edit     | edit      |
      | Details  | details   |
      | Delete   | delete    |
