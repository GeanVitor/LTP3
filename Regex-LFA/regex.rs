use regex::Regex;
use std::io;

fn main() {
    println!("Digite um CPF no formato XXX.XXX.XXX-XX:");

    let mut input = String::new();

    match io::stdin().read_line(&mut input) {
        Ok(_) => {
            let trimmed_input = input.trim();

            if verifica_cpf(trimmed_input) {
                println!("CPF válido!");
            } else {
                println!("CPF inválido!");
            }
        }
        Err(error) => {
            eprintln!("Erro ao ler a entrada do usuário: {}", error);
        }
    }
}

fn verifica_cpf(cpf: &str) -> bool {
    let re = Regex::new(r"^\d{3}\.\d{3}\.\d{3}-\d{2}$").unwrap();

    if re.is_match(cpf) {
        let numeros: String = cpf.chars().filter(|c| c.is_digit(10)).collect();

        let digitos: Vec<u32> = numeros.chars().map(|d| d.to_digit(10).unwrap()).collect();

        if digitos.len() == 11 {
            let parte_1 = calcula_digito(&digitos[..9]);
            let parte_2 = calcula_digito(&digitos[..10]);

            return parte_1 == digitos[9] && parte_2 == digitos[10];
        }
    }
    false
}

fn calcula_digito(digitos: &[u32]) -> u32 {
    let soma = digitos.iter().rev().enumerate().fold(0, |acc, (i, &d)| acc + (i + 2) as u32 * d);
    let resto = soma % 11;

    if resto < 2 {
        resto
    } else {
        11 - resto
    }
}