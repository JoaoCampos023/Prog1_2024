// OPERADORES 

int a = 3;
int b = a++; // ++ é um Operador acumulador
// Neste ++ vai somar a + 1
// Entretanto o acumulo vai ocorrer depois da atribuição pois o ++ esta do lado direirot de a
WriteLine($"a é {a}, b é {b}");
// ------------------

int c = 3;
int d = ++c;
// Neste caso o ++ esta do lado esquerdo de c
// Portanto o acumulo ocorre antes da atribuição
WriteLine($"c é {c}, d é {d}");
// --------------------

// Copmbinando operadores de atribuição

int p = 6;
p += 3; // Equivalente a p = p + 3;
p -= 3; // Equivalente a p = p - 3;
p *= 3; // Equivalente a p = p * 3;
p /= 3; // Equivalente a p = p / 3;

// Operadores Logicos

bool b_A = true;
bool b_B = false;

WriteLine($"AND  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}");
WriteLine($"b_A  | {b_B & b_A, -5} | {b_B & b_B, -5}");

WriteLine();

WriteLine($"OR   | b_A   | b_B  ");
WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
WriteLine($"b_A  | {b_B | b_A, -5} | {b_B | b_B, -5}");

WriteLine();

WriteLine($"XOR  | b_A   | b_B  ");
WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
WriteLine($"b_A  | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");


