#ifndef COMPOSITION_HPP
#define COMPOSITION_HPP

#include <iostream>
#include <memory>

namespace composition {

class Walker {  // interface
 public:
  virtual void walk() = 0;
};

class Legs : public Walker {
 public:
  void walk() { std::cout << "Walking with my legs" << std::endl; }
};

class Wheels : public Walker {
 public:
  void walk() { std::cout << "Rolling with my wheels" << std::endl; }
};

class Grabber {  // Interface
 public:
  virtual void grab() = 0;
};

class Arms : public Grabber {
 public:
  void grab() { std::cout << "Grabbing things with my arms" << std::endl; }
};

class InheritanceRobot : public Legs, public Arms {
 public:
  // Walk() and GrabThings() methods are implicitly
  // defined for this class since it inherited those
  // methods from its two superclasses
};

class CompositionRobot {
 public:
  CompositionRobot(std::unique_ptr<Walker> legs, std::unique_ptr<Grabber> arms)
      : legs_(std::move(legs)), arms_(std::move(arms)) {}

  void walk() { legs_->walk(); }
  void grab() { arms_->grab(); }

 private:
  std::unique_ptr<Walker> legs_;
  std::unique_ptr<Grabber> arms_;
};

}  // namespace composition

#endif  // COMPOSITION_HPP
