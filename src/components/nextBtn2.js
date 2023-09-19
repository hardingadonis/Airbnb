function NextButton2({ onClick, isHovering }) {
    const onClickk =(e)=>{
        e.preventDefault()
        onClick()
    }
    return (
      <button
        className={`NEXT_BTN absolute  bg-white-u1 w-8 h-8 
        hover:border-c1 hover:border-solid  hover:border-white  hover:bg-white
        rounded-full  right-c12 y-center box-shadow-u2  z100
       ${isHovering === true ? "" : "hidden"}`}
        onClick={e=>onClickk(e)}
      >
        <i
          className="fa-solid fa-angle-right fa-sm"
          style={{ color: "#222222", marginLeft: "0px" }}
        ></i>
      </button>
    );
  }
  
  export default NextButton2;
  