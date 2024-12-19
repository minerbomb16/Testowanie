Feature: Nawigacja między stronami
  Scenario Outline: Przejście na stronę <Page>
    Given użytkownik otwiera stronę "<Page>"
    Then użytkownik powinien zobaczyć stronę "<Page>"

    Examples:
      | Page       |
      | Categories |
      | Products   |
      | Orders     |

  Scenario: Przejście z kategorii na stronę główną
    Given użytkownik otwiera stronę "Categories"
    When użytkownik klika przycisk "Home"
    Then użytkownik powinien zobaczyć stronę "Home"
