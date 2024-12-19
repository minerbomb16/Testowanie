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
