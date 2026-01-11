export class Counter {
  count = 0

  increment() {
    setTimeout(() => {
      this.count++
    }, 100)
  }
}
