pub fn is_leap_year(year: u64) -> bool {
    match year {
        year if year % 400 == 0 => true,
        year if year % 100 == 0 => false,
        year if year % 4 == 0 => true,
        _ => false
    }
}
