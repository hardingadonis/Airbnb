import { Link } from "react-router-dom";
import { useDispatch } from "react-redux";
import { setLogInFrom } from "../reducer/accSlice";

export default function WhistlistBtn() {
  const dispatch = useDispatch();
  const handleOnClick = () => dispatch(setLogInFrom("/wishlists"));
  
  const path = window.location.pathname.replace("/Airbnb", "");

  return (
    <Link
      to="/wishlists"
      className=" flex items-center flex-col gap-c3  mt-c12 mb-2 w-1/5"
      onClick={handleOnClick}
    >
      <svg
        xmlns="http://www.w3.org/2000/svg"
        viewBox="0 0 32 32"
        aria-hidden="true"
        role="presentation"
        focusable="false"
        className={`icon-whistlists  
        ${path === "/wishlists" ? "stroke-main" : "stroke-current opacity-60"}`}
      >
        <path d="M16 28c7-4.73 14-10 14-17a6.98 6.98 0 0 0-7-7c-1.8 0-3.58.68-4.95 2.05L16 8.1l-2.05-2.05a6.98 6.98 0 0 0-9.9 0A6.98 6.98 0 0 0 2 11c0 7 7 12.27 14 17z"></path>
      </svg>
      <span
        className={`${
          path === "/wishlists" ? "text-black222 font-semibold" : ""
        }`}
      >
        Whistlists
      </span>
    </Link>
  );
}
