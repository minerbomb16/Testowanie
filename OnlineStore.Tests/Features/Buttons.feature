Feature: Testowanie przycisków Edit, Details i Delete
  Background:
    Given baza danych zawiera 3 kategorie, 3 produkty i 3 zamówienia

  Scenario Outline: Przycisk <Button> dla pierwszego elementu
    Given użytkownik otwiera stronę "<Page>"
    When użytkownik klika przycisk "<Button>" dla pierwszego elementu
    Then użytkownik powinien zostać przeniesiony na stronę "/<Page>/<urlSuffix>/1"

    Examples:
      | Page       | Button  | urlSuffix |
      | categories | Edit    | edit      |
      | categories | Details | details   |
      | categories | Delete  | delete    |
      | products   | Edit    | edit      |
      | products   | Details | details   |
      | products   | Delete  | delete    |
      | orders     | Edit    | edit      |
      | orders     | Details | details   |
      | orders     | Delete  | delete    |
