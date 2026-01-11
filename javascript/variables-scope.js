let a = 10
const b = 20

function testScope() {
  let a = 30
  return a + b
}

export { a, b, testScope }
console.log(testScope()) // Outputs: 50
console.log(a) // Outputs: 10