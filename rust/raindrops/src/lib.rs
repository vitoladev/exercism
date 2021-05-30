fn is_factor(n: u32, factor: u32, result: &str) -> &str {
    match n % factor == 0 {
        true => result,
        _ => "",
    }
}

pub fn raindrops(n: u32) -> String {
    let is_factor_by_3 = is_factor(n, 3, "Pling");
    let is_factor_by_5 = is_factor(n, 5, "Plang");
    let is_factor_by_7 = is_factor(n, 7, "Plong");

    let result = format!("{}{}{}", is_factor_by_3, is_factor_by_5, is_factor_by_7);
    match result == "" {
        true => n.to_string(),
        false => result
    }
}
