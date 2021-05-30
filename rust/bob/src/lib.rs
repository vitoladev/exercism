fn is_shout(input: &str) -> bool {
    !is_empty(input) && is_alphabetic(input) && input == input.to_uppercase()
}

fn is_alphabetic(input: &str) -> bool {
    input.trim().chars().any(char::is_alphabetic)
}

fn is_empty(input: &str) -> bool {
    input == ""
}

pub fn reply(message: &str) -> &str {
    let input = message.trim_end();
    let is_question = input.ends_with("?");

    match (is_empty(input), is_question, is_shout(input)) {
        (_, true, true) => "Calm down, I know what I'm doing!",
        (_, _, true) => "Whoa, chill out!",
        (_, true, _) => "Sure.",
        (true, _, _) => "Fine. Be that way!",
        _ => "Whatever.",
    }
}
