export const numbers = [1, 2, 3, 4, 5]

export const doubled = numbers.map(n => n * 2)
export const evens = numbers.filter(n => n % 2 === 0)
export const sum = numbers.reduce((a, b) => a + b, 0)
