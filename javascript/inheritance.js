class BaseService {
  getBase() {
    return "Base"
  }
}

export class ChildService extends BaseService {
  getChild() {
    return this.getBase() + " Child"
  }
}
