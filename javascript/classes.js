export class UserService {
  constructor(name) {
    this.name = name
  }

  getUser() {
    return this.name
  }
}
